using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody
{

     public class Peremennye
    {
        //static void Main(string[] args)
        //{
            //Console.WriteLine(Peremennye.GetEquationStraight(1, 1, 0, 0));
            
           // Console.WriteLine(Peremennye.(9, 36));


               // }
         public static double GetFormulaResult(double A, double B)
        {
            if (A == B)
            {
                throw new ArgumentException("попытка деления на ноль");

            }
            else
            {
                double C = (5 * A + B * B) / (B - A);

                return C;
            }
        }
        public static string ChangeStrings(string a, string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
            return $"a = {a}, b = {b}";
           
        }
        public static double CalculateDivision(double a, double b)
        { 
           double c = a / b;
            if(b==0)
            {
                throw new DivideByZeroException("попытка деления на ноль");
            }
            return c;
        }
        public static double CalculateDivisionRemainder(double a, double b)
        {
            double c = a % b;
            if (b == 0)
            {
                throw new DivideByZeroException("попытка получения остатка от деления на ноль");
            }
            return c;
        }
        public static double SolveLinearEquation(double A, double B, double C)
        {
            double X = (C - B) / A;
            if (A == 0)
            {
                throw new DivideByZeroException("попытка деления на ноль");
            }
            return X;
        }
        public static string GetEquationStraight(double x1, double y1, double x2, double y2)
        {

            double a = (y2 - y1) / (x2 - x1);
            double b = -((x1 * y2) - (x2 * y1)) / (x2 - x1);
            if (x2==x1)
            {
                throw new DivideByZeroException("координаты абсцисс прямой совпадают=>деление на ноль");

            }
            if(b==-0)
                b = 0;
            return $"y = {a}*x+{b}";
            
            
        }









       
        

    }
}
