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
        protected decimal productPrice;


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

        public void SetProductPrice(decimal productPrice)
        {
            this.productPrice = productPrice;
        }

        public decimal GetProductPrice()
        {
            return productPrice;
        }
    }
}
