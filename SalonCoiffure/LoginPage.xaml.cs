using SalonCoiffure.Data;
using SalonCoiffure.ViewModel;
using System.Windows;
using System.Windows.Controls;

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
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    var profilePage = new ProfilePage(user);
                    NavigationService?.Navigate(profilePage);

                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

            }
        }
    }
}
