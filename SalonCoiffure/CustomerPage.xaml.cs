using System.Windows;
using System.Windows.Controls;
using SalonCoiffure.Data;
using SalonCoiffure.ViewModel;

namespace SalonCoiffure
{
    /// <summary>
    /// Logique d'interaction pour CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {

        private CustomerViewModel _viewModel;

        public CustomerPage()
        {
            InitializeComponent();
            var db = new AppDbContext();
            _viewModel = new CustomerViewModel(new CustomerDataProvider(db));
            DataContext = _viewModel;
            Loaded += OnLoaded;
        }

        public async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }

    }
}
