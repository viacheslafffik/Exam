using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1.Panels
{
    public partial class PanelPrice : UserControl
    {
        private readonly Form1 main;
        private readonly BindingSource bs = new BindingSource();

        public PanelPrice(Form1 form)
        {
            InitializeComponent();
            main = form;

            NumericPrice.DecimalPlaces = 2;
            NumericPrice.Maximum = 100000;
            bs.DataSource = main.Services;
            GridServices.AutoGenerateColumns = true;
            GridServices.DataSource = bs;
        }

        private void ButtonAddService_Click(object sender, EventArgs e)
        {
            var name = ServiceName.Text;
            if (name.Length == 0) return;

            if (main.Services.Any(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase))) return;

            main.Services.Add(new Service
            {
                Name = name,
                Price = NumericPrice.Value
            });

            ServiceName.Clear();
            NumericPrice.Value = NumericPrice.Minimum;
        }

        private void ButtonWordExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "Word (*.docx)|*.docx", FileName = "Прайс.docx" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                Word.Application app = null;
                Word.Document doc = null;

                try
                {
                    app = new Word.Application();
                    doc = app.Documents.Add();

                    var data = main.Services.Where(s => !string.IsNullOrWhiteSpace(s?.Name)).ToList();

                    var table = doc.Tables.Add(doc.Range(0, 0), data.Count + 1, 3);
                    table.Borders.Enable = 1;

                    table.Cell(1, 1).Range.Text = "№";
                    table.Cell(1, 2).Range.Text = "Назва";
                    table.Cell(1, 3).Range.Text = "Ціна";

                    for (int i = 0; i < data.Count; i++)
                    {
                        table.Cell(i + 2, 1).Range.Text = (i + 1).ToString();
                        table.Cell(i + 2, 2).Range.Text = data[i].Name;
                        table.Cell(i + 2, 3).Range.Text = data[i].Price.ToString("0.00");
                    }

                    doc.SaveAs2(sfd.FileName);
                }
                finally
                {
                    if (doc != null) { doc.Close(false); Marshal.ReleaseComObject(doc); }
                    if (app != null) { app.Quit(); Marshal.ReleaseComObject(app); }
                }
            }
        }
    }
}
