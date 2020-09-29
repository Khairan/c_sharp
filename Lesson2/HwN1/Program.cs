using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
// №1
//Написать метод, возвращающий минимальное из трёх чисел.

namespace HwN1
{
    public class Program
    {
        public static void Signature()
        {
            //Вывод подписи
            Console.WriteLine($"\nCopyright (©) Glotov Andrei. {DateTime.Now.Year}");
            Console.ReadKey();
        }

        public static string ParamRequest(string paramName)
        {
            // Запрашиваем параметр и возвращаем ответ
            Console.Write($"Введите {paramName}: ");
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {

            int a, b, c, min = 0;

            Console.WriteLine("Минимальное из трех чисел: a, b, c");            
            a = Convert.ToInt32(ParamRequest("a"));
            b = Convert.ToInt32(ParamRequest("b"));
            c = Convert.ToInt32(ParamRequest("c"));
                                                
            if (a <= b && a <= c) min = a;
            else if (b <= c) min = b;
            else min = c;

            Console.WriteLine($"\nmin = {min}");
            Signature();

        }
    }
}
