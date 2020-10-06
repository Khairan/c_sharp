using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
//Задание №1
//Дан целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
//Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

namespace HwN1
{
    class Program
    {
        private static bool Div3(int a)
        {
            return a % 3 == 0;
        }

        static void Main(string[] args)
        {
            int length = 20;

            Console.WriteLine($"Массив из {length} элементов: ");

            int[] storage = new int[length];
            var rand = new Random();            

            for (int i = 0; i < length; i++)
            {
                storage[i] = rand.Next(-10000, 10000);
                Console.Write($"{storage[i]} ");
            }

            int count = 0;

            for (int i = 0; i < length; i++)
            {
                if (i < length - 1)
                {
                    bool a = Div3(storage[i]);
                    bool b = Div3(storage[i + 1]);
                    if (a && !b || b && !a) count++;
                }                    
            }

            Console.WriteLine($"\nКоличество пар элементов массива, в которых только одно число делится на 3: {count}");
            Console.ReadKey();
        }
               
    }
}
