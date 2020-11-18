using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    class Notebook : Gadget
    {
        public string keyboardBacklight;
        public int cores;
        public int hardDriveVolume;
        public static bool ifNotebook; //для определения, про ноутбук ли идет формирование информации

        public static Notebook generate()
        {
            string[] backlightValues = new string[] { "нет", "красная", "синяя", "зеленая", "разноцветная" };
            int[] values = new int[] { 1, 2, 4, 128, 256, 512 };
            return new Notebook
            {
                keyboardBacklight = backlightValues[rnd.Next() % 5],
                cores = (int)Math.Pow(2, rnd.Next(3)),
                hardDriveVolume = values[rnd.Next() % 6]
            };
        }

        public override string getInfo()
        {
            ifNotebook = true;
            string info = "Ноутбук";
            info += String.Format("\n*Подсветка клавиатуры - {0}", keyboardBacklight);

            string coreCase;
            if (cores == 1) coreCase = "ядро";
            else if (cores == 2 || cores == 4) coreCase = "ядра";
            else coreCase = "ядер";
            info += String.Format("\n*{0} {1}", cores, coreCase);

            string HDDMeasure;
            if (hardDriveVolume >= 128) HDDMeasure = "Гб";
            else HDDMeasure = "Тб";
            info += String.Format("\n*Объем жесткого диска - {0} {1}", hardDriveVolume, HDDMeasure);
            
            info += base.getInfo();
            ifNotebook = false;
            return info;
        }
    }
}
