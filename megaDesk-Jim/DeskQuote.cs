using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

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

        private const decimal RUSH_3DAYS = 60.00M;
        private const decimal RUSH_5DAYS = 40.00M;
        private const decimal RUSH_7DAYS = 30.00M;


        public Desk Desk { get; set; }

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public decimal QuotePrice { get; set; }

        public Delivery DeliveryType { get; set; }

        public decimal getRushOrderPrice()
        {
            decimal rushPrice = 0;
            if (this.DeliveryType == Delivery.Rush3Days)
            {
                rushPrice = RUSH_3DAYS;
            }
            else if (this.DeliveryType == Delivery.Rush5Days)
            {
                rushPrice = RUSH_5DAYS;
            }
            else if (this.DeliveryType == Delivery.Rush7Days)
            {
                rushPrice = RUSH_7DAYS;
            }
            else
            {
                rushPrice = 0;
            }
            return rushPrice;
        }

        public decimal getQuotePrice()
        {
            decimal price = BASE_DESK_PRICE;
            decimal surfaceArea = this.Desk.Width * this.Desk.Depth;

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
