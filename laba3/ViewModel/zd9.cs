using System.Collections.Generic;
using System.Windows.Controls;

namespace laba3.ViewModel
{
    internal class zd9
    {
        List<Phone> phones = new List<Phone>()
        {
            new Phone { Model="iPhone 13 pro", Brend="Apple", Price=94990, Camera = 12 },
            new Phone { Model="iPhone 14 pro", Brend="Apple", Price=104990, Camera = 48 },
            new Phone { Model="iPhone 15 pro", Brend="Apple", Price=154990, Camera = 48 },
            new Phone {Model="samsung s10+", Brend="Samsung", Price=100000, Camera = 12 },
            new Phone {Model="samsung s20 ultra", Brend="Samsung", Price=110000, Camera=200}

        };
        public class Phone
        {
            public string Model { get; set; }
            public int Price { get; set; }
            public string Brend { get; set; }
            public int Camera { get; set; }

            public override string ToString() => $"{Model} {Brend} {Camera} {Price}";

        }
        public void Metod(DataGrid DGR)
        {
            foreach (Phone phone in phones)
            {
                DGR.Items.Add(phone);
            }
        }
    }
}
