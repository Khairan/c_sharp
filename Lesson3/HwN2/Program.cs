using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
//С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел.
//Сами числа и сумму вывести на экран, используя tryParse.

namespace HwN2
{
    class Program
    {
        static bool Odd(int number)
        {
            if (number <= 0) return false;
            return number % 2 != 0;
        }

        static void AskNumbers(ref int sum, ref List<int> numbers)
        {
            int number; bool f;

            do
            {
                Console.Write("Число: ");
                f = int.TryParse(Console.ReadLine(), out number);
                if (Odd(number))
                {
                    sum += number;
                    numbers.Add(number);
                }

            } while (!f || number != 0);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Подсчет суммы всех нечётных положительных чисел.\nВводите по очереди целые числа, для завершения введите 0\n");

            int sum = 0;
            List<int> numbers = new List<int>(); //"Экспериментировал с массивами

            AskNumbers(ref sum, ref numbers);

            Console.Write($"\nНечетные положительные числа: {String.Join(", ",numbers)}");
            Console.WriteLine($"\nСумма: {sum}");
            Console.ReadKey();
        }

        
    }
}
