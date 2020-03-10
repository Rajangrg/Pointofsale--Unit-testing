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
            Product product = new Product();

            //Act
            product.SetProductName("A");
            string result = product.GetProductName();

            //Assert
            Assert.AreEqual("A", result);
        }

        [Test]
        public void GetProductQuantity()
        {
            //Arrange
            Product product = new Product();

            //Act
            product.SetProductQuantity(5);
            int result = product.GetProductQuantity();

            //Assert
            Assert.AreEqual(5, result);
        }


        [Test]
        public void GetProductPrice()
        {
            //Arrange
            Product product = new Product();

            //Act
            product.SetProductPrice(5);
            decimal result = product.GetProductPrice();

            //Assert
            Assert.AreEqual(5, result);
        }


    }
}
