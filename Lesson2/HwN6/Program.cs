using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN1.Program;

//Глотов Андрей
// №6
//*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
//«Хорошим» называется число, которое делится на сумму своих цифр.
//Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

namespace HwN6
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Подсчет количества 'хороших' чисел в диапазоне от 1 до 1 000 000 000");

            int maxValue = 1000000;
            int counter = 0;

            DateTime start = DateTime.Now;

            for (int i = 1; i <= maxValue; i++)
            {
                int temp = i;
                int sum = 0;
                while (temp > 0)
                {
                    sum = sum + (temp % 10);
                    temp = temp/10;
                }
                if (i % sum == 0) counter++;
            }
                        
            Console.WriteLine($"Хороших чисел в числе {maxValue:### ### ###} = {counter}");
            Console.WriteLine($"Затрачено времени на подсчет {DateTime.Now - start}");
            Signature();

        }
    }
}
