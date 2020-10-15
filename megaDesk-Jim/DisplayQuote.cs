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

            DeskQuote deskQuote = new DeskQuote();
            
            var delivery= add.cmbDelivery.SelectedItem;
            var material = add.cmbSurefaceM.SelectedValue;
            labelName.Text = add.name.Text;
            labelWidth.Text = add.numerWidth.Value.ToString();
            labelDepth.Text = add.numerDepth.Value.ToString();
            labelDrawers.Text = add.numerDrawers.Value.ToString();
            labelDelivery.Text = delivery.ToString();
            labelMaterial.Text = material.ToString();
            labelPrice.Text = deskQuote.getQuotePrice().ToString();

            //priceText.Text = add.getQuote_Click();
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
