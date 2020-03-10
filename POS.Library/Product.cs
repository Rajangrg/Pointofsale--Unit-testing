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


        public void SetProductName(string productName)
        {
            this.productName = productName;
        }

        public string GetProductName()
        {
            return productName;
        }
    }
}
