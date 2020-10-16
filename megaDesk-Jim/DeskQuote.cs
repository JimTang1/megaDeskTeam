using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megaDesk_Jim
{
    public enum Delivery
    {
        Rush3Days,
        Rush5Days,
        Rush7Days,
        Normal14Days,
    }

    public class DeskQuote
    {
        private const decimal BASE_DESK_PRICE = 200.00M;
        private const decimal SURFACE_AREA_COST = 1.00M;
        private const decimal DRAWER_COST = 50.00M;

        private const decimal OAK_COST = 200.00M;
        private const decimal LAMINATE_COST = 100.00M;
        private const decimal PINE_COST = 50.00M;
        private const decimal ROSEWOOD_COST = 300.00M;
        private const decimal VENEER_COST = 125.00M;

        public Desk Desk { get; set; }

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public decimal QuotePrice { get; set; }

        public Delivery DeliveryType { get; set; }

        public int getRushOrderPrice()
        {
            int[,] rushPrices = new int[3,3];
            int rushPrice = 0;
            string line;
            int col = 0;
            int row = 0;
            StreamReader rushPriceFile = new StreamReader(@"rushOrderPrices.txt");

            try
            {
                while ((line = rushPriceFile.ReadLine()) != null)
                {
                    if (col > 2)
                    {
                        col = 0;
                        row++;
                    }
                    rushPrices[row, col] = int.Parse(line);
                    col++;
                }

                decimal surfaceArea = this.Desk.Depth * this.Desk.Width;

                if (this.DeliveryType == Delivery.Rush3Days) // row 0
                {
                    if (surfaceArea < 1000)
                        rushPrice = rushPrices[0, 0];
                    else if (surfaceArea <= 2000)
                        rushPrice = rushPrices[0, 1];
                    else if (surfaceArea > 2000)
                        rushPrice = rushPrices[0, 2];
                }
                else if (this.DeliveryType == Delivery.Rush5Days) // row 1
                {
                    if (surfaceArea < 1000)
                        rushPrice = rushPrices[1, 0];
                    else if (surfaceArea <= 2000)
                        rushPrice = rushPrices[1, 1];
                    else if (surfaceArea > 2000)
                        rushPrice = rushPrices[1, 2];
                }
                else if (this.DeliveryType == Delivery.Rush7Days) // row 2
                {
                    if (surfaceArea < 1000)
                        rushPrice = rushPrices[2, 0];
                    else if (surfaceArea <= 2000)
                        rushPrice = rushPrices[2, 1];
                    else if (surfaceArea > 2000)
                        rushPrice = rushPrices[2, 2];
                }
                else
                {
                    rushPrice = 0;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("There is an error when you calculate a rushPrice. {0}",
                    err.InnerException.ToString());
            }

            return rushPrice;
        }

        public decimal getQuotePrice()
        {
            decimal price = BASE_DESK_PRICE;
            decimal surfaceArea = Desk.Width * Desk.Depth;

            //count the price of surface area 
            if(surfaceArea > 1000)
            {
                price += (surfaceArea - 1000) * SURFACE_AREA_COST;
            }


            if (this.Desk.SurfaceMaterial == DeskTopMaterial.Oak)
            {
                price += OAK_COST;
            }
            else if(this.Desk.SurfaceMaterial == DeskTopMaterial.Laminate)
            {
                price += LAMINATE_COST;
            }
            else if (this.Desk.SurfaceMaterial == DeskTopMaterial.Pine)
            {
                price += PINE_COST;
            }
            else if (this.Desk.SurfaceMaterial == DeskTopMaterial.Rosewood)
            {
                price += ROSEWOOD_COST;
            }
            else
            {
                price += VENEER_COST;
            }
            price += DRAWER_COST * this.Desk.NumberOfDrawers;

            price += getRushOrderPrice();

            return price;
        }
    }
}
