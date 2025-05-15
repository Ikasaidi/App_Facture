using SalonCoiffure.Data;
using SalonCoiffure.Model;
using SalonCoiffure.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace SalonCoiffure
{
    /// <summary>
    /// Logique d'interaction pour ReceiptWindow.xaml
    /// </summary>
    public partial class ReceiptWindow : Page
    {
        private readonly FactureViewModel _viewModel;

        public ReceiptWindow()
        {
            InitializeComponent();

            var db = new AppDbContext();
            _viewModel = new FactureViewModel(
                new CustomerDataProvider(db),
                new ServiceDataProvider(db),
                new FactureDataProvider(db));  // Stocker l'instance dans _viewModel

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
