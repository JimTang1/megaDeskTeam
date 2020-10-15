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
    public partial class DisplayQuote : Form
    {
        private Form _addQuote;
        private DeskQuote _deskQuote;

        public DisplayQuote(AddQuote addQuote, DeskQuote deskQuote)
        {
            InitializeComponent();

            _addQuote = addQuote;
            _deskQuote = deskQuote;

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

            this.numerWidth.Value = _deskQuote.Desk.Width;
            this.numerDepth.Value = _deskQuote.Desk.Depth;
            this.numerDrawers.Value = _deskQuote.Desk.NumberOfDrawers;
            this.cmbSurefaceM.SelectedIndex = (int)_deskQuote.Desk.SurfaceMaterial;
            this.name.Text = _deskQuote.CustomerName;
            this.cmbDelivery.SelectedIndex = (int)_deskQuote.DeliveryType;
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _addQuote.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
