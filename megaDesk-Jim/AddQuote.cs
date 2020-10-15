using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megaDesk_Jim
{
    public partial class AddQuote : Form
    {
        private Desk _desk; 
        private DeskQuote _deskQuote;

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

            // Initializing defaults:
            numerWidth.Text = "";
            numerDepth.Text = "";
            numerDrawers.Text = "";

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
            _desk = new Desk();
            _desk.Width = (int)this.numerWidth.Value;
            _desk.Depth = (int)this.numerDepth.Value;
            _desk.NumberOfDrawers = (int)this.numerDrawers.Value;
            _desk.SurfaceMaterial = (DeskTopMaterial)this.cmbSurefaceM.SelectedValue;

            _deskQuote = new DeskQuote();
            _deskQuote.CustomerName = this.name.Text;
            _deskQuote.Desk = _desk;
            _deskQuote.DeliveryType = (Delivery)this.cmbDelivery.SelectedItem;
            _deskQuote.QuoteDate = DateTime.Now;

            var displayQuote = new DisplayQuote(this, _deskQuote);
            displayQuote.Show();
            this.Hide();
        }
    }
}
