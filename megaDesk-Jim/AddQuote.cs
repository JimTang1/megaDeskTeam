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
    public partial class AddQuote : Form
    {
        public object SurfaceMaterial { get; private set; }
        public object DateTiem { get; private set; }

        public AddQuote()
        {
            InitializeComponent();

            //populate surfaceMaterial combo box
            this.numerWidth.Maximum = Desk.MAX_WIDTH;
            this.numerWidth.Minimum = Desk.MIN_WIDTH;

            this.numerDepth.Maximum = Desk.MAX_DEPTH;
            this.numerDepth.Minimum = Desk.MIN_DEPTH;

            this.numerDrawers.Maximum = Desk.MAX_DRAWERS;
            this.numerDrawers.Minimum = Desk.MIN_DRAWERS;

            List<DeskTopMaterial> materials = Enum.GetValues(typeof(DeskTopMaterial))
                            .Cast<DeskTopMaterial>()
                            .ToList();

            cmbSurefaceM.DataSource = materials;
            cmbSurefaceM.SelectedIndex = -1;

            

            List<Delivery> deliveryDay = Enum.GetValues(typeof(Delivery))
                            .Cast<Delivery>()
                            .ToList();

            cmbDelivery.DataSource = deliveryDay;
            cmbDelivery.SelectedIndex = -1;

    }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form MainMenu = (Form)this.Tag;
            MainMenu.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getQuote_Click(object sender, EventArgs e)
        {

            Desk desk = new Desk();
            desk.Width = (int)this.numerWidth.Value;
            desk.Depth = (int)this.numerDepth.Value;
            desk.NumberOfDrawers = (int)this.numerDrawers.Value;
            desk.SurfaceMaterial = (DeskTopMaterial)this.cmbSurefaceM.SelectedValue;

            DeskQuote deskQuote = new DeskQuote();
            deskQuote.CustomerName = this.name.Text;
            deskQuote.Desk = desk;
            deskQuote.DeliveryType = (Delivery)this.cmbDelivery.SelectedItem;
            deskQuote.QuoteDate = DateTime.Now;
            deskQuote.QuotePrice = deskQuote.getQuotePrice();

            DisplayQuote displayQuote = new DisplayQuote(this, deskQuote);
            displayQuote.Show();
            
            this.Hide();

            addQuoteToFile(deskQuote);
        }

        private void addQuoteToFile(DeskQuote deskQuote)
        {
            // create a quote file
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

            // add a new quote
            deskQuotes.Add(deskQuote);

            // Save a quote to a json file
            saveQuote(deskQuotes);

        }

        private void saveQuote(List<DeskQuote> deskQuotes)
        {
            var quotesFile = @"quote.json";

            string JSONResult = JsonConvert.SerializeObject(deskQuotes);
            using (StreamWriter writer = new StreamWriter(quotesFile))
            {
                writer.WriteLine(JSONResult.ToString());
                writer.Close();
            }
        }
    }
}
