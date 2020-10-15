using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megaDesk_Jim
{
    public partial class SearchQuotes : Form
    {
        Form _mainMenu;
        List<DeskQuote> _deskQuotes = new List<DeskQuote>();
        List<DeskQuote> _filtered = new List<DeskQuote>();
        DataTable _dataTable = new DataTable();

        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;

            List<DeskTopMaterial> materials = Enum.GetValues(typeof(DeskTopMaterial))
                           .Cast<DeskTopMaterial>()
                           .ToList();

            surfaceMaterial.DataSource = materials;
            surfaceMaterial.SelectedIndex = -1;
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            var quotesFile = @"quote.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            // read json files first
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();

                    // check if quotes list is not empty
                    if (quotes.Length > 0)
                    {
                        // Deserializing desk quotes list
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }
            _deskQuotes = deskQuotes;
      
            _dataTable.Columns.Add("Date");
            _dataTable.Columns.Add("Name");
            _dataTable.Columns.Add("Width");
            _dataTable.Columns.Add("Depth");
            _dataTable.Columns.Add("# Drawers");
            _dataTable.Columns.Add("Material");
            _dataTable.Columns.Add("Delivery");
            _dataTable.Columns.Add("Price");

            deskQuotes.ForEach(quote =>
            {
                _dataTable.Rows.Add(
                    quote.QuoteDate,
                    quote.CustomerName,
                    quote.Desk.Width,
                    quote.Desk.Depth,
                    quote.Desk.NumberOfDrawers,
                    quote.Desk.SurfaceMaterial,
                    quote.DeliveryType,
                    quote.QuotePrice
                    );
            });

            this.searchedQuotes.AutoGenerateColumns = true;
            this.searchedQuotes.Columns.Clear();
            this.searchedQuotes.Rows.Clear();
            this.searchedQuotes.DataSource = _dataTable;
            this.searchedQuotes.AutoResizeColumns();
        }

       



        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void surfaceMaterial_SelectedValueChanged(object sender, EventArgs e)
        {
           // this.searchedQuotes.Rows.Clear();
           _filtered = _deskQuotes.FindAll(quote => quote.Desk.SurfaceMaterial == (DeskTopMaterial)this.surfaceMaterial.SelectedItem);
            _dataTable.Rows.Clear();

            _filtered.ForEach(quote =>
            {
                _dataTable.Rows.Add(
                    quote.QuoteDate,
                    quote.CustomerName,
                    quote.Desk.Width,
                    quote.Desk.Depth,
                    quote.Desk.NumberOfDrawers,
                    quote.Desk.SurfaceMaterial,
                    quote.DeliveryType,
                    quote.QuotePrice
                    );
            });

            //this.searchedQuotes.DataSource = _deskQuotes.FindAll
            //    (quote => quote.Desk.SurfaceMaterial == (DeskTopMaterial)this.surfaceMaterial.SelectedItem);
            // this.searchedQuotes.DataSourceChanged
        }
    }
}
