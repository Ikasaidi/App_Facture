using System.Windows;
using System.Windows.Controls;

namespace dash_app
{
    public partial class FacturePage : Page
    {
        public FacturePage()
        {
                InitializeComponent();
        }

        private void navigate(object sender, RoutedEventArgs args) 
        {
            string url = (string) this.Content;
            args.Source = new Uri(url+"Page.xaml", UriKind.Relative);
        }
    }
}
