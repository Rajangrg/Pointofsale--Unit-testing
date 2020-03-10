using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library
{
    public class Product
    {
        protected string productName;
        protected int productQuantity;
        protected double productPrice;

        //constructor 
        public Product(string productName, int productQuantity, double productPrice)
        {
            this.productName = productName;
            this.productQuantity = productQuantity;
            this.productPrice = productPrice;
        }


        public void SetProductName(string productName)
        {
            this.productName = productName;
        }

        public string GetProductName()
        {
            return productName;
        }

        public void SetProductQuantity(int productQuantity)
        {
            this.productQuantity = productQuantity;
        }

        public int GetProductQuantity()
        {
            return productQuantity;
        }

        public void SetProductPrice(double productPrice)
        {
            this.productPrice = productPrice;
        }

        public double GetProductPrice()
        {
            return productPrice;
        }
    }
}
