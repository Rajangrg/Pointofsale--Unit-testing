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


    }
}
