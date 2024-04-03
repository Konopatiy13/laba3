using System;
using System.Windows.Controls;

namespace laba3.ViewModel
{
    internal class zd4
    {
        public void Metod(string tb1, string tb2, Label lb4)
        {
            int a = Convert.ToInt32(tb1);
            int b = Convert.ToInt32(tb2);

            int maxZnach, minZnach;
            string maxForm, minForm;
            switch (a + b)
            {
                case 10:
                    maxZnach = a * b;
                    maxForm = "a * b";
                    break;
                default:
                    maxZnach = a + b;
                    maxForm = "a + b";
                    break ;
            }
            switch (a - b)
            {
                case 0:
                    minZnach = a / b;
                    minForm = "a / b";
                    break;
                default:
                    minZnach = a - b;
                    minForm = "a - b";
                    break ;
            }
            lb4.Content = $"Максимальное значение: {maxZnach} (вычислено по формуле {maxForm}).\n" +
                                  $"Минимальное значение: {minZnach} (вычислено по формуле {minForm}).";
        }
    }
}
