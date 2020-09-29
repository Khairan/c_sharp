using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN1.Program;

//Глотов Андрей
// №5
//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace HwN5
{        
    class Program
    {
        static void Main(string[] args)
        {

            double underweight = 18.50, overweight = 25, kg;

            Console.WriteLine("Рассчет индекса массы тела (ИМТ).\nВес указывается в килограммах (80), а рост в метрах (1,80)");
            double m = Convert.ToDouble(ParamRequest("Вес"));
            double h = Convert.ToDouble(ParamRequest("Рост"));

            double imt = m / Math.Pow(h, 2);

            Console.WriteLine($"\nВаш ИМТ = {imt:f2}");

            if (imt < underweight)
            {
                kg = (underweight - imt) * Math.Pow(h, 2);
                Console.WriteLine($"Вам нужно набрать {kg:f2} кг");
            }
            else if (imt > overweight)
            {
                kg = (imt - overweight) * Math.Pow(h, 2);                
                Console.WriteLine($"Вам нужно скинуть {kg:f2} кг");
            }
            else Console.WriteLine("Ваш вес в норме");

            Signature();
        }
    }
}
