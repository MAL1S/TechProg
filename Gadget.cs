using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie
{
    class Gadget
    {
        double displaySize;
        protected static Random rnd = new Random();

        public virtual string getInfo()
        {
            Random rnd = new Random();
            //чтобы корректно показать размер дисплея для разных гаджетов
            //так как, например, нет телефона с диагональю в 17 дюймов
            if (Tablet.ifTablet) displaySize = rnd.Next(60, 130);
            else if (Smartphone.ifPhone) displaySize = rnd.Next(30, 70);
            else if (Notebook.ifNotebook) displaySize = rnd.Next(120, 170);
            displaySize /= 10;
            return String.Format("\nДиагональ дисплея - {0} дюймов", displaySize);
        }

        public override string ToString()
        {
            if (this is Tablet) return "Планшет";
            if (this is Smartphone) return "Смартфон";
            if (this is Notebook) return "Ноутбук";
            //пока от этого класса наследуются только эти 3 класса, последний return никогда не сработает
            return "Какой-то другой гаджет"; 
        }
    }
}
