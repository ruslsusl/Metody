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
        [TestCase(1, 3, 5, "5, 3, 1")]
        [TestCase(2, 10, 4, "10, 4, 2" )]
        [TestCase(-1, -4, -2, "-1, -2, -4")]
        [TestCase(0, -10, -3, "0, -3, -10")]
        [TestCase(5.4, 7.7, -1, "7,7, 5,4, -1")]
        [TestCase(3, -1, 7, "7, 3, -1")]
        public void PutNumbersInOrder(double A, double B, double C, string expected)
        {
            string actual = StructuryVetvleniya.PutNumbersInOrder(A, C, B);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, -2, 3, "Решения нет")]
        [TestCase(1, -2, 1, "Ответ: X =1")]
        [TestCase(-1, -2, 3, "Ответ: X1 = -3, X2 = 1")]
        public void SolveKvadratnoeUravneniye(double A, double B, double C, string expected)
        {
            string actual = StructuryVetvleniya.SolveKvadratnoeUravneniye(A, B, C);
            Assert.AreEqual(expected, actual);
        }
    }
}
