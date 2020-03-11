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
        [Test] //discount on six-pack
        public void GetTotalValueForSixSameProductC()
        {
            //Arrange
            
            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();

            //Product product = new Product("C", 12, 1);
            Product product = new Product("C", 6, 1);

            //Act
            pointOfSale.ScanProduct(product);
           
            //Assert

            Assert.AreEqual(1, pointOfSale.DiscountForC("C"));
            //Assert.AreEqual(10, pointOfSale.DiscountForC("C"));
        }

        [Test] 
        public void GetTotalValueForfourSameProductC()
        {
            //Arrange
            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();
            Product product = new Product("C", 5, 1);

            //Act
            pointOfSale.ScanProduct(product);

            //Assert
            Assert.AreEqual(5, pointOfSale.DiscountForC("C"));
        }


        [Test] //discount on three when bought together
        public void GetTotalValueFoThreeSameProductA()
        {
            //Arrange

            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();
            Product product = new Product("A", 3, 1.25);

            //Act
            pointOfSale.ScanProduct(product);

            //Assert

            Assert.AreEqual(3, pointOfSale.DiscountForA("A"));
           
        }


        [Test] //
        public void GetTotalValueFoTwoSameProductA()
        {
            //Arrange

            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();
            Product product = new Product("A", 2, 1.25);

            //Act
            pointOfSale.ScanProduct(product);

            //Assert

            Assert.AreEqual(2.5, pointOfSale.DiscountForA("A"));

        }

    }
}
