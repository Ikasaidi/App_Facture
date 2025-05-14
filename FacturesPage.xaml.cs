using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace dashStackApp
{
    /// <summary>
    /// Interaction logic for FacturesPage.xaml
    /// </summary>
    public partial class FacturesPage : Window
    {
        public FacturesPage()
        {
            InitializeComponent();
            AddButtonsToGrid();
        }

        private void PdfGenerator_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "FacturesDashStack",
                DefaultExt = ".pdf",
                Filter = "Document PDF (.pdf)|*.pdf"
            };

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                string path = dlg.FileName;

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(QuestPDF.Helpers.Colors.White);

                        page.Header()
                            .Text("Factures")
                            .Bold().FontSize(50).FontColor(QuestPDF.Helpers.Colors.Blue.Medium);

                        page.Content()
                            .PaddingVertical(1, Unit.Centimetre)
                            .Column(column =>
                            {
                                column.Item().Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(1);
                                        columns.RelativeColumn(2);
                                    });

                                    void AddRow(string label, string value)
                                    {
                                        table.Cell().Element(CellStyle).Text(label).SemiBold();
                                        table.Cell().Element(CellStyle).Text(value);
                                    }

                                    static IContainer CellStyle(IContainer container)
                                    {
                                        return container
                                            .PaddingVertical(5)
                                            .PaddingHorizontal(10)
                                            .BorderBottom(1)
                                            .BorderColor(QuestPDF.Helpers.Colors.Grey.Lighten2);
                                    }

                                    AddRow("Items", ProduitsNom.Text);
                                    AddRow("Quantité", ProduitsQuantite.Text);
                                    AddRow("Prix unitaire ($)", ProduitsPrixUnitaire.Text);
                                    AddRow("Total HT ($)", PrixGST.Text);
                                    AddRow("Total TVA ($)", PrixQST.Text);
                                    AddRow("Prix Total ($)", PrixTotal.Text);
                                });
                            });

                    });
                }).GeneratePdf(path);

                MessageBox.Show("PDF généré avec succès!", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void EmailFormOpener_Click(object sender, EventArgs e) 
        {
            EmailForm emailForm = new EmailForm();
            emailForm.Show();
        }


        private void AddButtonsToGrid()
        {
            for (int i = 1; i < 9; i++)
            {
                Button button = new Button
                {
                    Content = DynamicBtnNaming(i),
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#111F64")),
                    BorderThickness = new Thickness(0),
                    Foreground =  new SolidColorBrush(System.Windows.Media.Colors.White)
                };

                Grid.SetRow(button, i);

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



        private void DeleteFactures_Click(object sender, EventArgs e) { }


        private void AddFactures_Click(object sender, EventArgs e) { }


        private void UpdateFactures_Click(object sender, EventArgs e) { }
    }
}
