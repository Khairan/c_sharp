using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN1.Program;

//Глотов Андрей №4
//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.

namespace HwN4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа обмена значениями двух переменных a и b");
           
            int a = Convert.ToInt32(ParamRequest("a"));
            int b = Convert.ToInt32(ParamRequest("b"));

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a = {a}, b = {b}");

            a = a ^= b;
            b = b ^= a;
            a = a ^= b;
            
            Console.WriteLine($"a = {a}, b = {b}");

            (a, b) = (b, a);

            Console.WriteLine($"a = {a}, b = {b}");

            Signature(); // вывод подписи из HwN1.Program

        }
    }
}
