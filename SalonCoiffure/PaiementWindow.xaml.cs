using SalonCoiffure.ViewModel;
using System.Windows.Controls;

namespace SalonCoiffure
{
    /// <summary>
    /// Logique d'interaction pour PaiementWindow.xaml
    /// </summary>
    public partial class PaiementWindow : Page
    {
        public PaiementWindow()
        {
            InitializeComponent();
            DataContext = new PaiementViewModel();

        }
    }
}
