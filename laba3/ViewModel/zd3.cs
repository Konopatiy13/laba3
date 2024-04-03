using System;
using System.Windows.Controls;

namespace laba3.ViewModel
{
    internal class zd3
    {
        public void Metod(string tb, Label lb)
        {
            int numMounth = Convert.ToInt32(tb);
            string nameMounth;
            string season;

            switch (numMounth)
            {
                case 1:
                    nameMounth = "январь";
                    season = "зима";
                    break;
                case 2:
                    nameMounth = "февраль";
                    season = "зима";
                    break;
                case 3:
                    nameMounth = "март";
                    season = "весна";
                    break;
                case 4:
                    nameMounth = "апрель";
                    season = "весна";
                    break;
                case 5:
                    nameMounth = "май";
                    season = "весна";
                    break;
                case 6:
                    nameMounth = "июнь";
                    season = "лето";
                    break;
                case 7:
                    nameMounth = "июль";
                    season = "лето";
                    break;
                case 8:
                    nameMounth = "август";
                    season = "лето";
                    break;
                case 9:
                    nameMounth = "сентябрь";
                    season = "осень";
                    break;
                case 10:
                    nameMounth = "октябрь";
                    season = "осень";
                    break;
                case 11:
                    nameMounth = "ноябрь";
                    season = "осень";
                    break;
                case 12:
                    nameMounth = "декабрь";
                    season = "зима";
                    break;
                default:
                    nameMounth = "";
                    season = "";
                    break;
            }
            if(nameMounth != "" && season != "")
            {
                lb.Content = $"{numMounth} – {nameMounth}, {season}.";
            }
            else { lb.Content = "Ошибка"; }
        }
    }
}
