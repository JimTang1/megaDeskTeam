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
    public partial class ViewAllQuotes : Form
    {
        private Form _mainMenu;
        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
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

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Width");
            dataTable.Columns.Add("Depth");
            dataTable.Columns.Add("# Drawers");
            dataTable.Columns.Add("Material");
            dataTable.Columns.Add("Delivery");
            dataTable.Columns.Add("Price");

            deskQuotes.ForEach(quote => 
            {
                dataTable.Rows.Add(
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

            this.listOfQuotes.AutoGenerateColumns = true;
            this.listOfQuotes.Columns.Clear();
            this.listOfQuotes.Rows.Clear();
            this.listOfQuotes.DataSource = dataTable;
            this.listOfQuotes.AutoResizeColumns();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
