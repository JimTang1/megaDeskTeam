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
        public AddQuote()
        {
            InitializeComponent();

            //populate surfaceMaterial combo box


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

            this.numerWidth.Maximum = Desk.MAX_WIDTH;
            this.numerWidth.Minimum = Desk.MIN_WIDTH;
            this.numerDepth.Maximum = Desk.MAX_DEPTH;
            this.numerDepth.Minimum = Desk.MIN_DEPTH;
            this.numerDrawers.Maximum = Desk.MAX_DRAWERS;
            this.numerDrawers.Minimum = Desk.MIN_DRAWERS;

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
    }
}
