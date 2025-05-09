using SalonCoiffure.Data;
using SalonCoiffure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalonCoiffure
{
    /// <summary>
    /// Logique d'interaction pour LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private CustomerViewModel _viewModel;
        public LoginPage()
        {
            InitializeComponent();
            _viewModel = new CustomerViewModel(new CustomerDataProvider());
            DataContext = _viewModel;
            Loaded += OnLoaded;
        }
        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var username = UsernameTextBox.Text;
            var password = PasswordBox.Password;

            using (var db = new AppDbContext())
            {
                var client = db.Customers.FirstOrDefault(c => c.Username == username && c.Password == password);

                if (client != null)
                {
                    MessageBox.Show("Login successful!");
                    // proceed to main window or dashboard
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

            }
        }
    }
}
