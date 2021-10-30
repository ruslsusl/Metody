using NUnit.Framework;

namespace Metody.Test
{
    public class PeremennyeTests
    {
        [TestCase(6,7,79)]
        [TestCase(2, 4, 13)]
        public void GetFormulaResult(double A, double B,double C)
        
        {
            


                double actual = Peremennye.GetFormulaResult(A, B);
            
            Assert.AreEqual(actual, C);
        }

        [TestCase("ABC", "XYZ", "a = XYZ, b = ABC")]
        
        public void ChangeStrings(string A, string B, string expected)
        {
            string actual = Peremennye.ChangeStrings(A, B);
            Assert.AreEqual(actual, expected);

        }
        [TestCase(6, 2, 3)] 
        [TestCase(-8, -4, 2)] 
        [TestCase(60, 0, 5)] 
        [TestCase(27, 9, 3)] 
        [TestCase(2.25, 1.5, 1.5)] 
        public void CalculateDivision(double a, double b, double expected) 
        { 
            double actual = Peremennye.CalculateDivision(a, b); 
            Assert.AreEqual(expected, actual); 
        }
        [TestCase(2, 10, 2)]
        [TestCase(4, 0, 4)]
        [TestCase(9, 36, 25)]
        public void CalculateDivisionRemainder(double a, double b, double expected)
        {
            double actual = Peremennye.CalculateDivisionRemainder(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 10, 2,-4)]
        [TestCase(0, 0, 4, 4)]
        [TestCase(10, -36, 64, 10)]
        public void SolveLinearEquation(double A, double B, double C, double expected)
        {
            double actual = Peremennye.SolveLinearEquation(A, B, C);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1, 2, 2, "y= 1*x+0")]
        [TestCase(4, 1, 4, 3, "y=x+5")]
        [TestCase(3, 2, 2, 4, "y=-2x+8")]
        public void GetEquationStraight(double x1, double y1, double x2, double y2, double expected)
        {
            string actual = Peremennye.GetEquationStraight(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }



    }
}