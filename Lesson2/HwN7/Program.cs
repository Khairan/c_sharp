using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN1.Program;

//Глотов Андрей
// №7
//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

namespace HwN7
{
    class Program
    {

        static int Recursion(int a, int b, int sum)
        {
            Console.Write("{0,2} ", a);
            sum = sum + a;
            if (a < b)
            {
                return Recursion(a + 1, b, sum);
            }
            else return sum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Вывод чисел от a до b при помощи рекурсии");
            int a = Convert.ToInt32(ParamRequest("a"));
            int b = Convert.ToInt32(ParamRequest("b"));
            int sum = 0;

            sum = Recursion(a, b, sum);
            Console.WriteLine($"\nСумма чисел = {sum}");

            Signature();
        }
    }
}
