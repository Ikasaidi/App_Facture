using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SalonCoiffure.Data;
using SalonCoiffure.Model;

namespace SalonCoiffure.ViewModel
{
    public partial class CustomerViewModel : ObservableObject
    {

        private readonly ICustomerDataProvider _customerDataProvider;

        [ObservableProperty]
        private Customer _selectedCustomer;

        [ObservableProperty]
        private string searchText;

        public ObservableCollection<Customer> Customers { get; } = new ObservableCollection<Customer>();
        public ObservableCollection<Customer> FilteredCustomers { get; } = new ObservableCollection<Customer>();

        public CustomerViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
            SelectedCustomer = new Customer();
        }

        public async Task LoadAsync()
        {
            var customers = await _customerDataProvider.GetAllAsync();
            

            if (customers != null)
            {
                Customers.Clear();
                FilteredCustomers.Clear();

                foreach (var customer in customers)
                {
                    Customers.Add(customer);
                    FilteredCustomers.Add(customer);
                }
            }
        }
        partial void OnSearchTextChanged(string value)
        {
            FilterCustomers();
        }

        private void FilterCustomers()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                //afficher tout
                FilteredCustomers.Clear();
                foreach (var customer in Customers)
                {
                    FilteredCustomers.Add(customer);
                }
            }
            else
            {
                var filtered = Customers
                    .Where(c => c.Nom.Contains(SearchText))
                    .ToList();

                FilteredCustomers.Clear();
                foreach (var customer in filtered)
                {
                    FilteredCustomers.Add(customer);
                }
            }
        }

        [RelayCommand]
        private void Add()
        {
            if (SelectedCustomer != null)
            {
                var newCustomer = new Customer
                {
                    Nom = SelectedCustomer.Nom,
                    Telephone = SelectedCustomer.Telephone,
                    Email = SelectedCustomer.Email,
                    Adresse = SelectedCustomer.Adresse
                };

                Customers.Add(newCustomer);
                FilteredCustomers.Add(newCustomer);
                SelectedCustomer = new Customer();
                
            }
        }
        [RelayCommand]
        private void Update() {
            if (SelectedCustomer != null)
            {
                var index = Customers.IndexOf(SelectedCustomer);
                if (index >= 0)
                {
                    Customers[index] = SelectedCustomer;
                }
            }
        }

        [RelayCommand]
        private void Delete()
        {
            if (SelectedCustomer != null)
            {
                Customers.Remove(SelectedCustomer);
                FilteredCustomers.Remove(SelectedCustomer);
                SelectedCustomer = new Customer();
            }
        }

        
    }
}
