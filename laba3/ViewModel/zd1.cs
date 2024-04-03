using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace laba3.ViewModel
{
    internal class zd1
    {
        public void Metod(string tb, Label lb)
        {
            int year;
            if (int.TryParse(tb, out year) && year > 0)
            {
                int century;

                switch ((year - 1) / 100 + 1)
                {
                    case 0:
                        century = 0;
                        break;
                    case 1: 
                        century = 1; 
                        break;

                    default:
                        century = (year - 1) / 100 + 1;
                        break;

                }
                lb.Content = $"Номер столетия для года {year} - {century}";
            }
            else
            {
                lb.Content = $"Некорректный ввод, введите положительное число";
            }
        }
    }
}
