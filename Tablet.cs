using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    class Tablet : Gadget
    {
        public bool cameraPresense;
        public int screenDpi;
        public static bool ifTablet; //для определения, про планшет ли идет формирование информации

        public static Tablet generate()
        {
            return new Tablet
            {
                cameraPresense = rnd.Next(2) == 1,
                screenDpi = rnd.Next(120, 640)
            };
        }

        public override string getInfo()
        {
            ifTablet = true;
            string info = "Планшет";
            info += String.Format("\n*Камера {0}", cameraPresense ? "имеется" : "не имеется");
            info += String.Format("\n*DPI экрана - {0}", screenDpi);
            info += base.getInfo();
            ifTablet = false;
            return info;
        }
    }
}
