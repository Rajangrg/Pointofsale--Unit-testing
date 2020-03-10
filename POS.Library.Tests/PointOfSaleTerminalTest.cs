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
    }
}
