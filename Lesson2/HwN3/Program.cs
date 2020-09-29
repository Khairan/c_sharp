using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN1.Program;

//Глотов Андрей
// №3
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace HwN3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number, sum = 0;
            Console.WriteLine("Подсчет суммы всех нечетных положительных чисел.\nВвод прервется при вводе числа 0");

            do
            {
                number = Convert.ToInt32(ParamRequest("число"));
                if (number > 0 && number % 2 == 1)
                {
                    sum = sum + number;
                }

            } while (number != 0);

            Console.WriteLine($"Сумма нечетных положительных чисел = {sum}");
            Signature();


        }
    }
}
