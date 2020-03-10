using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Library.Tests
{
    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void GetProductName()
        {
            //Arrange
            Product product = new Product("A", 1, 1.25);

            //Act
            string result = product.GetProductName();

            //Assert
            Assert.AreEqual("A", result);
        }

        [Test]
        public void GetProductQuantity()
        {
            //Arrange
            Product product = new Product("B", 5, 4.25);

            //Act
            int result = product.GetProductQuantity();

            //Assert
            Assert.AreEqual(5, result);
        }


        [Test]
        public void GetProductPrice()
        {
            //Arrange
            Product product = new Product("C", 1, 1);

            //Act
            double result = product.GetProductPrice();

            //Assert
            Assert.AreEqual(1, result);
        }


        [Test]
        public void GetProductDescription()
        {
            //Arrange
            Product product = new Product("D", 1, 0.75);

            //Act
            string productNameResult = product.GetProductName();
            int prductQuantityResult = product.GetProductQuantity();
            double productPriceResult = product.GetProductPrice();


            //Assert
            Assert.AreEqual("D", productNameResult);
            Assert.AreEqual(1, prductQuantityResult);
            Assert.AreEqual(0.75, productPriceResult);
        }

    }
}
