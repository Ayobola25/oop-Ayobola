using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Ayobola
{
    internal interface IBakery 
    {
        public double Price(double amount);
    }

    public class BakeryOrders : IBakery
    {

        public BakeryOrders()
        {
            PriceSmallBread = 100;
            PriceMediumBread = 300;
            PriceLargeBread = 500;
        }

        public double PriceSmallBread { get; private set; }
        public double PriceMediumBread { get; private set; }
        public double PriceLargeBread { get; private set; }

        public double Price(double smallAmount)
        { 
           double price = PriceSmallBread * smallAmount; 
            return price;
        }

        public double Price(double smallAmount, double mediumAmount)
        {
            double price = (PriceSmallBread * smallAmount) + (PriceMediumBread * mediumAmount);
            return price;
        }
            
            
        public double Price(double smallAmount, double mediumAmount, double largeAmount) 
        {
               double price = (PriceSmallBread * smallAmount) + (PriceMediumBread * mediumAmount) + (PriceLargeBread * largeAmount);
                return (price);
        }
        
    }

}


    

