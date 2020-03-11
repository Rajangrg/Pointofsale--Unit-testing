using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library.Tests
{
    [TestFixture]
    public class PointOfSaleTerminalTest
    {

        [Test]
        public void NoItemIsAddedOnPointOfSaleTerminal()
        {
            //Arrange
            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();

            //Act
            int result = pointOfSale.ItemCount();

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ItemIsAddedOnPointOfSaleTerminal()
        {
            //Arrange
            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();
            Product A = new Product("A", 1, 1.25);

            //Act
            pointOfSale.ScanProduct(A);
            int result = pointOfSale.ItemCount();

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test] //Given input to check
        public void TotalPriceBeforeDiscountForFourdifferentProduct()
        {
            //Arrange
            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();
            Product A = new Product("A", 1, 1.25);
            Product B = new Product("B", 1, 4.25);
            Product C = new Product("C", 1, 1.00);
            Product D = new Product("D", 1, 0.75);

            //Act
            pointOfSale.ScanProduct(A);
            pointOfSale.ScanProduct(B);
            pointOfSale.ScanProduct(C);
            pointOfSale.ScanProduct(D);

            double result = pointOfSale.GetTotalPriceBeforeDiscount();

            //Assert
            Assert.AreEqual(7.25, result);
        }

        [Test] //Given input to check
        public void TotalPriceBeforeDiscountForSevenSameProduct()
        {
            //Arrange
            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();
            Product C = new Product("C", 7, 1);

            //Act
            pointOfSale.ScanProduct(C);
            double result = pointOfSale.GetTotalPriceBeforeDiscount();

            //Assert
            Assert.AreEqual(7, result); 
        }

        [Test] //Given input to check
        public void TotalPriceBeforeDiscountForDifferentOrMoreThanOneSameProduct()
        {
            //Arrange
            PointOfSaleTerminal pointOfSale = new PointOfSaleTerminal();
            Product A = new Product("A", 3, 1.25);
            Product B = new Product("B", 2, 4.25);
            Product C = new Product("C", 1, 1.00);
            Product D = new Product("D", 1, 0.75);

            //Act
            pointOfSale.ScanProduct(A);
            pointOfSale.ScanProduct(B);
            pointOfSale.ScanProduct(C);
            pointOfSale.ScanProduct(D);

            double result = pointOfSale.GetTotalPriceBeforeDiscount();

            //Assert
            Assert.AreEqual(14, result);
        }

    }
}
