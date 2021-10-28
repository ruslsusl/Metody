using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody
{

     class Peremennye
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFormulaResult(3, 5) );


                }
         static double GetFormulaResult(double A, double B)
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
        static string ChangeStrings(string a, string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
            return $"a = {a}, b = {b}";
           
        }
         static double CalculateDivision(double a, double b)
        { 
           double c = a / b;
            return c;
        }
         static double CalculateDivisionRemainder(double a, double b)
        {
            double c = a % b;
            return c;
        }
         static double SolveLinearEquation(double A, double B, double C)
        {
            double X = (C - B) / A;
            return X;
        }
         static string GetEquationStraight(double x1, double y1, double x2, double y2)
        {

            double a = (y2 - y1) / (x2 - x1);
            double b = -((x1 * y2) - (x2 * y1)) / (x2 - x1);
            return $"y = {a}*x+{b}";
        }









       
        

    }
}
