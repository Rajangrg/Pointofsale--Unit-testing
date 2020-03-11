using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library
{
    public class PointOfSaleTerminal
    {
        protected List<Product> items; //for stroing items 
        protected double totalValueBeforeDiscount;

        //constructor
        public PointOfSaleTerminal()
        {
           items = new List<Product>();
        }

        public void ScanProduct(Product item)
        {
            this.items.Add(item);
        }

        public int ItemCount()
        {
            return items.Count(); //count all the items from the lists
        }

        public double GetTotalPriceBeforeDiscount()
        {
            //foreach gives permisssion to access the method of product
            // it is similar to creating an object of product
            foreach (var item in this.items)
            {
                totalValueBeforeDiscount =( totalValueBeforeDiscount + (item.GetProductQuantity() * item.GetProductPrice()));
            }
            return totalValueBeforeDiscount;
        }
    }
}
