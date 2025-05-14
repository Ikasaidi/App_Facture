using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;
using System.Windows;

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
        }

        private void PdfGenerator_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // Open file save dialog
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
                        page.PageColor(Colors.White);

                        page.Header()
                            .Text("Factures")
                            .Bold().FontSize(50).FontColor(Colors.Blue.Medium);

                        page.Content()
                            .PaddingVertical(1, Unit.Centimetre)
                            .Column(column =>
                            {
                                column.Item().Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(1); // Label column
                                        columns.RelativeColumn(2); // Value column
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
                                            .BorderColor(Colors.Grey.Lighten2);
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


        private void EmailSender_Click(object sender, EventArgs e) 
        {

        }
    }
}
