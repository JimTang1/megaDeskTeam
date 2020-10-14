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
        public DisplayQuote(AddQuote addQ)
        {
            InitializeComponent();
            add = addQ;
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            name.Text = add.name.Text;
            numerWidth.Value = add.numerWidth.Value;
            numerDepth.Value = add.numerDepth.Value;
            numerDrawers.Value = add.numerDrawers.Value;
            cmbSurefaceM.SelectedValue = add.cmbSurefaceM.SelectedValue;
            cmbDelivery.SelectedItem = add.cmbDelivery.SelectedItem;
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            add.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
