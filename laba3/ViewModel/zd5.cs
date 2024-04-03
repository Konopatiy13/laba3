using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace laba3.ViewModel
{
    internal class zd5
    {
        public void Metod(string tb1, Label lb3)
        {
            char c = tb1[0];
            string type;

            switch (c)
            {
                case char ch when Char.IsDigit(ch):
                    type = "Цифра";
                    break;
                case char ch when Char.IsLetter(ch):
                    type = "Латинская буква";
                    break;
                default:
                    type = "Не цифра и не латинская буква";
                    break;
            }
            lb3.Content = $"Тип символа: {type}";
        }
    }
}
