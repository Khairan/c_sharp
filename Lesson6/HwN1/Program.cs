using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глтов Андрей
//Задача №1
//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
//Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

namespace HwN1
{
    class Program
    {        
        public delegate double Fun(double x, double a);

        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine($"a = {a}");
            Console.WriteLine("---------------------");
        }
                
        public static double FuncPow(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }

        public static double FuncSin(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table(FuncPow, 0, 3, 5);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table(FuncSin, -2, 2, 5);

            Console.ReadKey();

        }
    }
}
