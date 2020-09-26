using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN1.Program;

//Глотов Андрей №2
//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

namespace HwN2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Рассчет индекса массы тела (ИМТ).\nВес указывается в килограммах (80), а рост в метрах (1,80)");

            // вызов процедуры ParamRequest происходит из HwN1.Program
            double m = Convert.ToDouble(ParamRequest("Вес"));
            double h = Convert.ToDouble(ParamRequest("Рост"));
            
            double imt = m / (h * h);

            Console.WriteLine($"ИМТ = {imt:f2}");

            Signature(); // вывод подписи из HwN1.Program

        }
    }
}
