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
    }
}
