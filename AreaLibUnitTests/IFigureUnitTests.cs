using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;
using System.Collections.Generic;

namespace AreaLibUnitTests
{
    [TestClass]
    public class IFigureUnitTests
    {

        /// <summary>
        /// Положительная проверка площади фигур.
        /// </summary>
        [TestMethod]
        public void GetAteaEquals()
        {
            AreaEquals(Math.PI * 4 , new Circle(2));
            AreaEquals(6, new Triangle(4, 3, 5));

        }

        /// <summary>
        /// Отрицательная проверка площади фигур.
        /// </summary>
        [TestMethod]
        public void GetAteaNotEquals()
        {
            AreaNotEquals(77, new Circle(2));
            AreaNotEquals(77, new Triangle(4, 3, 5));

        }

        private void AreaEquals(double area, IFigure figure)
        {
            Assert.AreEqual(area, figure.GetArea());
        }
        private void AreaNotEquals(double area, IFigure figure)
        {
            Assert.AreNotEqual(area, figure.GetArea());
        }
    }
}
