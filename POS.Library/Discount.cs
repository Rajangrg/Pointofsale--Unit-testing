using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library
{
    public class Discount
    {
        protected PointOfSaleTerminal productOfsale;
        protected Product product;

        //product C discount details
        protected int cProductQuantity;
        protected double totalPriceWithoutDiscountForC = 0;
        protected double totalPriceForC = 0;
        protected int perUnitPriceForC = 1;
        protected double cDiscountPrice = 16.667; //percentage

        public Discount()
        {
            productOfsale = new PointOfSaleTerminal();
        }
        public double DiscountForC(string productName)
        {

            foreach (var item in productOfsale.items)
            {
                if (item.GetProductName() == productName)
                {
                    for (int i = 0; i < productOfsale.ItemCount(); i++)
                    {
                        cProductQuantity += product.GetProductQuantity(); //get from Product class
                    }

                    totalPriceWithoutDiscountForC = cProductQuantity * perUnitPriceForC;
                    if (cProductQuantity >= 6)
                    {
                        totalPriceForC = Math.Round((totalPriceWithoutDiscountForC) - ((totalPriceWithoutDiscountForC * cDiscountPrice) / 100));
                        //totalPriceForC = (totalPriceForWithoutDiscountforC) - ((totalPriceForWithoutDiscountforC * cDscountPrice) / 100);
                    }
                    else if (cProductQuantity > 6)
                    {
                        totalPriceForC = Math.Round(((totalPriceWithoutDiscountForC) - (cProductQuantity / 6)));
                        //totalPriceForC = ((totalPriceForWithoutDiscountforC) - (cQantity / 6));
                    }
                    else
                    {
                        totalPriceForC = totalPriceWithoutDiscountForC;
                    }
                }
            }

          
            return totalPriceForC;
        }
    }
}
