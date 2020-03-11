using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library
{
    public class PointOfSaleTerminal
    {
        public List<Product> items; //for stroing items 
        protected double totalValueBeforeDiscount;


        //product C discount details -- refactor create seprate class
        protected int cProductQuantity;
        protected double totalPriceWithoutDiscountForC = 0;
        protected double totalPriceForC = 0;
        protected int perUnitPriceForC = 1;
        protected double cDiscountPrice = 16.667; // in percentage


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


        // Discount  -- refactor later 

        public double DiscountForC(string productName)
        {

            foreach (var item in this.items)
            {
                if (item.GetProductName() == productName)
                {
                    for (int i = 0; i < ItemCount(); i++)
                    {
                        cProductQuantity += item.GetProductQuantity(); // from Product class

                    }
                    totalPriceWithoutDiscountForC = cProductQuantity * 1;

                    if (cProductQuantity >= 6)
                    {
                        totalPriceForC = Math.Round((totalPriceWithoutDiscountForC) - ((totalPriceWithoutDiscountForC * cDiscountPrice) / 100));
                        //totalPriceForC = (totalPriceForWithoutDiscountforC) - ((totalPriceForWithoutDiscountforC * cDscountPrice) / 100);
                    }
               
                    else
                    {
                        totalPriceForC = totalPriceWithoutDiscountForC;
                    }
                }

            }

            return totalPriceForC; //total sum
        }



    }
}
