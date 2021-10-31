using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody
{
    public class StructuryVetvleniya
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Peremennye.GetEquationStraight(1, 1, 0, 0));

            Console.WriteLine(StructuryVetvleniya.WriteNumberInWords(19));


        }

        public static double CalculateTwoNumbers(double A, double B)
        {
            double result = 0;
            if (A > B)
            {
                result = A + B;
            }

            else if (A < B)

            {
                result = A - B;
            }


            else
            {
                result = A * B;
            }
            return result;
        }
        public static string ChooseQuarter(double X, double Y)
        {
            string result = "";
            if (X > 0 && Y > 0)

            {
                result = "Первая четверть";
            }


            if (X < 0 && Y > 0)

            { result = "Вторая четверть"; }

            if (X < 0 && Y < 0)

            { result = "Третья четверть"; }

            if (X > 0 && Y < 0)

            {
                result = "Четвертая четверть";
            }


            else if (X == 0 || Y == 0)
            {
                result = "Точка на Оси";
            }
            return result;
        }
        public static string PutNumbersInOrder(double A, double B, double C)
        {
            string result = "";
            if (A > B)
            {

                if (B > C)

                {
                    result = $"{A}, {B}, {C}";
                }



                else if (C < A)
                {
                    result = $"{A}, {C}, {B}";
                }
                else
                {
                    result = $"{C}, {A}, {B}";
                }
            }
            else
            {
                if (A > C)
                {
                    result = $"{B}, {A}, {C}";
                }
                else if (B > C)
                {
                    result = $"{B}, {C}, {A}";
                }
                else
                {
                    result = $"{C}, {B}, {A}";
                }

            }
            return result;
        }
        public static string SolveKvadratnoeUravneniye(double A, double B, double C)
        {
            string result = "";
            if (B * B - 4 * A * C > 0)
            {

                double X1 = ((-B + Math.Sqrt(B * B - 4 * A * C)) / 2 * A);
                double X2 = ((-B - Math.Sqrt(B * B - 4 * A * C)) / 2 * A);



                result = $"Ответ: X1 = {X1}, X2 = {X2}";

            }
            if (B * B - 4 * A * C == 0)
            {
                double X = -B / 2 * A;
                result = $"Ответ: X ={X}";

            }
            else if (B * B - 4 * A * C < 0)
            {

                result = "Решения нет";
            }
            return result;
        }
        public static  string WriteNumberInWords(int a)
        {
            int q = a / 10;
            int w = a % 10;
            string s = "";

            if (q == 1)
            {
                switch (a)
                {
                    case 10:


                        s = "Десять";

                        break;
                    case 11:


                        s = "Одиннадцать";

                        break;
                    case 12:

                        s = "Двенадцать";

                        break;
                    case 13:
                        {
                            s = "Тринадцать";
                        }
                        break;
                    case 14:
                        {
                            s = "Четырнадцать";
                        }
                        break;
                    case 15:
                        {
                            s = "Пятнадцать";
                        }
                        break;
                    case 16:
                        {
                            s = "Шестнадцать";
                        }
                        break;
                    case 17:
                        {
                            s = "Семнадцать";
                        }
                        break;
                    case 18:
                        {
                            s = "Восемнадцать";
                        }
                        break;
                    case 19:
                        {
                            s = "Девятнадцать";
                        }
                        break;
                }
            }
            else

            { 

                switch (q)
                {
                    case 2:
                        s = "Двадцать ";
                        break;
                    case 3:
                        s = "Тридцать ";
                        break;
                    case 4:
                        s = "Сорок ";
                        break;
                    case 5:
                        s += "Пятьдесят ";
                        break;
                    case 6:
                        s = "Шестьдесят ";
                        break;
                    case 7:
                        s = "Семьдесят ";
                        break;
                    case 8:
                        s = "Восемьдесят ";
                        break;
                    case 9:
                        s = "Девяноста ";
                        break;
                }
                switch (w)
                {
                    case 1:
                        s = "Один ";
                        break;

                    case 2:
                        s = "Два ";
                        break;
                    case 3:
                        s = "Три ";
                        break;
                    case 4:
                        s += "Четыре ";
                        break;
                    case 5:
                        s = "Пять ";
                        break;
                    case 6:
                        s = "Шесть ";
                        break;
                    case 7:
                        s = "Семь ";
                        break;
                    case 8:
                        s = "Восемь ";
                        break;
                    case 9:
                        s = "Девять ";
                        break;
                }
            }
            return s;
        }

    }
}
