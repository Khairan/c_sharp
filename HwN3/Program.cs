using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN1.Program;

//Глотов Андрей №3
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
//    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

namespace HwN3
{
    class Program
    {
        static double DistanceCalc(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main()
        {
            Console.WriteLine("Рассчет расстояния между точками с координатами x1, y1 и x2, y2.");
            
            double x1 = Convert.ToDouble(ParamRequest("x1"));
            double y1 = Convert.ToDouble(ParamRequest("y1"));
            double x2 = Convert.ToDouble(ParamRequest("x2"));
            double y2 = Convert.ToDouble(ParamRequest("y2"));
                        
            Console.WriteLine($"Расстояние r = {DistanceCalc(x1, y1, x2, y2):f2}");

            Signature(); // вывод подписи из HwN1.Program

        }
    }
}
