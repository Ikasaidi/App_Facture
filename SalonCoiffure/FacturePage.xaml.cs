using SalonCoiffure.Data;
using SalonCoiffure.Model;
using SalonCoiffure.ViewModel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SalonCoiffure
{
    /// <summary>
    /// Logique d'interaction pour FacturePage.xaml
    /// </summary>
    public partial class FacturePage : Page
    {
        
        private readonly FactureViewModel _viewModel;

        public FacturePage()
        {
            InitializeComponent();

            var db = new AppDbContext();

            
            var customerProvider = new CustomerDataProvider(); 
            var serviceProvider = new ServiceDataProvider(db);
            var factureProvider = new FactureDataProvider(db); 

            _viewModel = new FactureViewModel(customerProvider, serviceProvider, factureProvider);
            DataContext = _viewModel;

            Loaded += ReceiptWindow_Loaded;
        }

        private async void ReceiptWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }

        private void ServicesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedServices = ServicesListBox.SelectedItems.Cast<Service>().ToList();
            _viewModel.UpdateSelectedServices(selectedServices);
        }
    }
}
