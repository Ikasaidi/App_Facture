using System.Windows;

namespace dash_app.vue
{
    public partial class ProfilPage : Window
    {
        public ProfilPage()
        {
            if (!this.Visibility.Equals(false)) // render juste s'il est appeler (empêche d'affaibler la performance)
            {
                InitializeComponent();
            }
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void navBar_OnClick(object sender, EventArgs e)
        {
            ProfilePage profilPage = new ProfilePage();
            FacturesPage facturesPage = new FacturesPage();
            // les restes des pages

            switch (this.Content)
            {
                case "Profil":
                    this.Visibility.Equals(false);
                    profilPage.Show();
                    break;
                case "Factures":
                    this.Visibility.Equals(false);
                    facturesPage.Show();
                    break;
                // les restes des pages
                default:
                    //this.Visibility.Equals(false);
                    //homePage.Show();
                    break;
            }
        }
    }
}