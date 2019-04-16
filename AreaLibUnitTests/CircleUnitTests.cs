using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;

namespace AreaLibUnitTests
{
    [TestClass]
    public class CircleUnitTests
    {
        /// <summary>
        /// Положительная проверка конструктора окружности.
        /// </summary>
        [TestMethod]
        public void ConstructOk()
        {
            var ob = new Circle(3);
        }

        /// <summary>
        /// Отрицательная проверка конструктора окружности.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ConstructError()
        {
            var ob = new Circle(-1);
        }
    }
}
