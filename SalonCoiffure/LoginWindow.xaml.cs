using SalonCoiffure.Data;
using SalonCoiffure.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace SalonCoiffure
{
    /// <summary>
    /// Logique d'interaction pour LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Page
    {
        private CustomerViewModel _viewModel;

        public LoginWindow()
        {
            InitializeComponent();
            var db = new AppDbContext();
            _viewModel = new CustomerViewModel(new CustomerDataProvider(db)); // Stocker l'instance dans _viewModel
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
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
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
