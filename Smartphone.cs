using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    class Smartphone : Gadget
    {
        public int simSlots;
        public double megaPixels;
        public int batteryVolume;
        public static bool ifPhone; //для определения, про телефон ли идет формирование информации

        public static Smartphone generate()
        {
            return new Smartphone
            {
                simSlots = rnd.Next() % 2 + 1,
                megaPixels = rnd.Next() % 12 + 2,
                batteryVolume = rnd.Next(15, 50) * 100
            };
        }

        public override string getInfo()
        {
            ifPhone = true;
            string info = "Смартфон";
            info += String.Format("\n*Слотов для сим-карты - {0}", simSlots);
            info += String.Format("\n*Камера {0} мегапикселей", megaPixels);
            info += String.Format("\n*Объем батареи - {0}", batteryVolume);
            info += base.getInfo();
            ifPhone = false;
            return info;
        }
    }
}
