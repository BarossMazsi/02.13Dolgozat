using Microsoft.VisualStudio.TestTools.UnitTesting;
using Egysegteszt_SzilagyiIstvanMarcell;
using System;

namespace RectangleTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void RectangleTestsForPosNumbers()
        {
            //Arrange
            var oldalak = new Rectangle();
            int a = 5;
            int b = 10;
            //Act
            int result = oldalak.CalculateArea(a,b);
            //Assert
            Assert.AreEqual(50, result);

        }
        [TestMethod]
        public void RectangleTestsIfWidhtZero()
        {
            //Arrange
            var oldalak = new Rectangle();
            int a = 0;
            int b = 10;
            //Act
            int result = oldalak.CalculateArea(a, b);
            //Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void RectangleTestsIfHeightZero()
        {
            //Arrange
            var oldalak = new Rectangle();
            int a = 10;
            int b = 0;
            //Act
            int result = oldalak.CalculateArea(a, b);
            //Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void RectangleTestsIfNegWidht()
        {
            //Arrange
            var oldalak = new Rectangle();
            int a = -5;
            int b = 10;
            //Act
            int result = oldalak.CalculateArea(a, b);
            //Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void RectangleTestsIfNegHeights()
        {
            //Arrange
            var oldalak = new Rectangle();
            int a = 10;
            int b = -5;
            //Act
            int result = oldalak.CalculateArea(a, b);
            //Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void RectangleTestsIfHighNumbers()
        {
            //Arrange
            var oldalak = new Rectangle();
            int a = 1000000;
            int b = 2000000;
            //Act
            int result = oldalak.CalculateArea(a, b);
            //Assert
            Assert.AreEqual(2000000000000, result);
        }
        [TestMethod]
        public void RectangleTestsNem()
        {
            //Arrange
            var oldalak = new Rectangle();
            int a = 4.5;
            int b = 8.2;
            //Act
            int result = oldalak.CalculateArea(a, b);
            //Assert
            Assert.AreEqual(36.9, result);
        }

    }
}
