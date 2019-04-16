using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;

namespace AreaLibUnitTests
{
    [TestClass]
    public class TriangleUnitTests
    {
        /// <summary>
        /// Положительная проверка конструктора треугольника.
        /// </summary>
        [TestMethod]
        public void ConstructOk()
        {
            var ob = new Triangle(3, 4, 5);
        }

        /// <summary>
        /// Отрицательная проверка конструктора треугольника.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ConstructError()
        {
            var ob = new Triangle(3, 4, 710);
        }

        /// <summary>
        /// Положительная проверка прямоугольности треугольника.
        /// </summary>
        [TestMethod]
        public void IsRightOk()
        {
            Assert.IsTrue(IsRight(new Triangle(4, 5, 3)));
        }

        /// <summary>
        /// отрицательная проверка прямоугольности треугольника.
        /// </summary>
        [TestMethod]
        public void IsRightError()
        {
            Assert.IsFalse(IsRight(new Triangle(5, 7, 3)));
        }

        private bool IsRight(Triangle ob)
        {
           //Возможнонадо было вынести метод в класс?
           return Math.Pow(ob.CSide, 2) == Math.Pow(ob.ASide, 2) + Math.Pow(ob.BSide, 2);
        }

    }
}
