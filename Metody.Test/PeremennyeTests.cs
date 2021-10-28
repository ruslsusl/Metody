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


    }
}