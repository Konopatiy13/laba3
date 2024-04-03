using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace laba3.ViewModel
{
    internal class zd7
    {
        public void Metod(string tb1, string tb2, Label lb4)
        {
            int year = int.Parse(tb1);
            int month = int.Parse(tb2);
            int daysInMonth;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        daysInMonth = 29;
                    else
                        daysInMonth = 28;
                    break;
                default:
                    daysInMonth = 0;
                    break;
            }
            lb4.Content = $"Количество дней в месяце: {daysInMonth}";
        }
    }
}
