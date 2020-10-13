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


            //var Desk = new Desk();
            //Desk.Width = numerWidth.Value;
            //Desk.Depth = numerDepth.Value;
            //Desk.NumberOfDrawers = (int)numerDrawers.Value;

            //Desk desk = new Desk
            //{
            //    Width = numerWidth.Value,
            //    Depth = numerDepth.Value,
            //    NumberOfDrawers = (int)numerDrawers.Value,
            //    SurfaceMaterial = (DeskTopMaterial)cmbSurefaceM.SelectedValue
            //};

            deskQuote.getQuotePrice();


        }
    }
}
