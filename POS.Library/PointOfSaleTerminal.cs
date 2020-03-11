using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library
{
    public class PointOfSaleTerminal
    {
        public List<Product> items; //for stroing items or scanned items
        protected double totalValueBeforeDiscount;


        //product C discount details
        //refactor later create seprate class for discount 

        protected int cProductQuantity;
        protected double totalPriceWithoutDiscountForC = 0;
        protected double totalPriceForC = 0d;
        protected double perUnitPriceForC = 1;
        protected double cDiscountPrice = 16.667; // in percentage

        //product C discount details 
        protected int aProductQuantity;
        protected double totalPriceWithoutDiscountForA = 0;
        protected double totalPriceForA = 0d;
        protected double perUnitPriceForA = 1.25;
        protected double aDiscountPrice = 25; // in percentage



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




        // ---------Discount---------
        //refactor create seperate class 

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
                    totalPriceWithoutDiscountForC = cProductQuantity * perUnitPriceForC;

                    if (cProductQuantity >= 6)
                    {
                        totalPriceForC = Math.Round((totalPriceWithoutDiscountForC) - ((totalPriceWithoutDiscountForC * cDiscountPrice) / 100));
                    }
                    else
                    {
                        totalPriceForC = totalPriceWithoutDiscountForC;
                    }
                }
            }

            return totalPriceForC; //total sum only for C
        }


        public double DiscountForA(string productName)
        {

            foreach (var item in this.items)
            {
                if (item.GetProductName() == productName)
                {
                    for (int i = 0; i < ItemCount(); i++)
                    {
                        aProductQuantity += item.GetProductQuantity(); // from Product class

                    }
                    totalPriceWithoutDiscountForA = aProductQuantity * perUnitPriceForA;

                    if (aProductQuantity >= 3)
                    {
                        totalPriceForA = Math.Round((totalPriceWithoutDiscountForA) - ((totalPriceWithoutDiscountForA * aDiscountPrice) / 100));       
                    }
                    else
                    {
                        totalPriceForA = totalPriceWithoutDiscountForA;
                    }
                }

            }
            return totalPriceForA; //total sum only for A
        }


    }
}
