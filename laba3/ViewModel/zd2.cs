using System;
using System.Windows.Controls;

namespace laba3.ViewModel
{
    internal class zd2
    {
        public void Metod(string tb1, string tb2, string tb3, Label lb5)
        {
            double a = Convert.ToDouble(tb1);
            double b = Convert.ToDouble(tb2);
            double c = Convert.ToDouble(tb3);

            double maxValue = Math.Max(Math.Max(a, b), c);
            string result;
            switch (maxValue)
            {
                case double max when a + b + c - max <= max:
                    result = "ты помойму перепутал";
                    break;
                case double x when a == b && b == c:
                    result = "Равносторонний треугольник";
                    break;
                case double x when a == b || b == c || a == c:
                    result = "Равнобедренный треугольник";
                    break;
                default:
                    result = "Ступенчатый треугольник";
                    break;
            }
            lb5.Content = result;
        }
    }
}
