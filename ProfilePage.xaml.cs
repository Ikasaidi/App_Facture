using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace dashStackApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ProfilePage : Window
    {
        public ProfilePage()
        {
            InitializeComponent();
            AddButtonsToGrid();
        }

        private void UpdateProfile_Click(object sender, EventArgs e) { }

        private void AddButtonsToGrid()
        {
            for (int i = 1; i < 9; i++)
            {
                Button button = new Button
                {
                    Content = DynamicBtnNaming(i),
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#111F64")),
                    BorderThickness = new Thickness(0),
                    Foreground =  new SolidColorBrush(Colors.White)
                };

                // Set the Grid.Row property dynamically
                Grid.SetRow(button, i);

                // Add the button to the existing Grid
                NavBarGrid.Children.Add(button);
            }
        }

        private string DynamicBtnNaming(int i)
        {
            switch (i)
            {
                case 1:
                    return "Clients";
                case 2:
                    return "Factures";
                case 3:
                    return "Paiements";
                case 4:
                    return "Services";
                case 5:
                    return "Contacts";
                case 6:
                    return "Profile";
                case 7:
                    return "Paramètres";
                case 8:
                    return "Déconnection";
                default:
                    return "";
            }
        }
    }
}