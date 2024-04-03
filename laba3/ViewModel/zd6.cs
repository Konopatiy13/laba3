using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace laba3.ViewModel
{
    internal class zd6
    {
        public void Metod(string tb1, Label lb3)
        {
            int month = int.Parse(tb1);
            int quartal;

            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    quartal = 1;
                    break;
                case 4:
                case 5:
                case 6:
                    quartal = 2;
                    break;
                case 7:
                case 8:
                case 9:
                    quartal = 3;
                    break;
                case 10:
                case 11:
                case 12:
                    quartal = 4;
                    break;
                default:
                    quartal = 0;
                    break;
            }
            lb3.Content = $"Номер квартала {quartal}";
        }
    }
}
