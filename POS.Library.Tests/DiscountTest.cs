using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library.Tests
{
    [TestFixture]
    public class DiscountTest
    {
        [Test] //discount on pack
        public void GetTotalValueForSixSameProduct()
        {
            //Arrange
            
            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();

            //Product product = new Product("C", 12, 1);
            Product product = new Product("C", 6, 1);

            //Act
            pointOfSale.ScanProduct(product);
           
            //Assert

            Assert.AreEqual(5, pointOfSale.DiscountForC("C"));
            //Assert.AreEqual(10, pointOfSale.DiscountForC("C"));
        }

    }
}
