using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace laba3.ViewModel
{
    internal class zd8
    {
        List<string> intem;

        public zd8()
        {
            intem = new List<string>();
            intem.AddRange(new string[] { "bit", "bait", "qwerty", "Gigabite" });
        }

        public void Metod1(ListView lv1)
        {
            foreach (var item in intem)
            {
                lv1.Items.Add(item);
            }


        }
    }
}
