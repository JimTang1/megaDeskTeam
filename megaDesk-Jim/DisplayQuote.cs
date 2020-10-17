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
        private AddQuote add;
        private DeskQuote _deskQuote;

        public DisplayQuote(AddQuote addQ, DeskQuote deskQuote)
        {
            InitializeComponent();
            add = addQ;
            _deskQuote = deskQuote;
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            labelName.Text = _deskQuote.CustomerName;
            labelWidth.Text = _deskQuote.Desk.Width.ToString();
            labelDepth.Text = _deskQuote.Desk.Depth.ToString();
            labelDrawers.Text = _deskQuote.Desk.NumberOfDrawers.ToString();
            labelDelivery.Text = _deskQuote.DeliveryType.ToString();
            labelMaterial.Text = _deskQuote.Desk.SurfaceMaterial.ToString();
            labelPrice.Text = "$" + _deskQuote.QuotePrice.ToString();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            add.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
