using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody.Test
{
    class StructuryVetvleniyaTests
    {
        [TestCase(3, 2, 5)]
        [TestCase(-4, 2, -6)]
        [TestCase(2, 2, 4)]
        [TestCase(-2, -2, 4)]
        [TestCase(-2, -3, -5)]
        [TestCase(-2, -1, -1)]


        public void CalculateTwoNumbers(double A, double B, double expected)
        {
            double actual = StructuryVetvleniya.CalculateTwoNumbers(A, B);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(1, 2, "Первая четверть")]
        [TestCase(-1, 2, "Вторая четверть")]
        [TestCase(1, -2, "Четвертая четверть")]
        [TestCase(-2, -2, "Третья четверть")]
        [TestCase(0, 2, "Точка на Оси")]
        [TestCase(2, 0, "Точка на Оси")]
        [TestCase(0, 0, "Точка на Оси")]


        public void ChooseQuarter(double X, double Y, string expected)
        {
            string actual = StructuryVetvleniya.ChooseQuarter(X, Y);
            Assert.AreEqual(expected, actual);
        }
    }
}
