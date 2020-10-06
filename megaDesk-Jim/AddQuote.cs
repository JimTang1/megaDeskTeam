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

            try
            {
                List<DeskTopMaterial> materials = Enum.GetValues(typeof(DeskTopMaterial))
                                            .Cast<DeskTopMaterial>()
                                            .ToList();

                cmbSurefaceM.DataSource = materials;
                cmbSurefaceM.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

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

        private void numerWidth_ValueChanged(object sender, EventArgs e)
        {
                numerWidth.Maximum = 96;
                numerWidth.Minimum = 24;
        }

        private void numerDepth_ValueChanged(object sender, EventArgs e)
        {
            numerDepth.Maximum = 48;
            numerDepth.Minimum = 12;
        }

        private void numerDrawers_ValueChanged(object sender, EventArgs e)
        {
            numerDrawers.Maximum = 7;
            numerDrawers.Minimum = 0;
        }
    }
}
