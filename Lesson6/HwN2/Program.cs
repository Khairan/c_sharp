using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Глтов Андрей
//Задача №2
//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
//б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).

namespace HwN2
{
    class Program
    {
        public delegate double Fun(double x);

        public static double Fx1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double Fx2(double x)
        {
            return Math.Pow(x, 3);
        }

        public static double Fx3(double x)
        {
            return x * Math.Sin(x);
        }

        public static void SaveFunc(Fun F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        
        public static List<double> LoadFunc(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);            
            min = double.MaxValue; double d;
            List<double> ls = new List<double>();
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                ls.Add(d);
                if (d < min) min = d;
            }            
            bw.Close();
            fs.Close();            
            return ls;
        }

        public static double ReadLine()
        {
            string s = Console.ReadLine();
            s = s.Replace('.', ',');           
            return double.Parse(s);
        }

        static void Main(string[] args)
        {
            var array = new Fun[3];
            array[0] = Fx1;
            array[1] = Fx2;
            array[2] = Fx3;

            Console.Write("Укажите номер функции от 1 до 3:" +
                            "\n 1 = x^2 - 50x + 10" +
                            "\n 2 = x^3" +
                            "\n 3 = x * sin(x)" +
                            "\nНомер функции: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Укажите начальное значение a = ");
            double a = ReadLine();
            Console.Write("Укажите конечное значение b = ");
            double b = ReadLine();
            Console.Write("Укажите шаг h = ");
            double h = ReadLine();

            SaveFunc(array[n-1], "data.bin", a, b, h);            
            double min;
            var ls = LoadFunc("data.bin", out min);            
            Console.Write("Массив значений: ");
            foreach (var item in ls)
            {
                Console.Write($"{item} ");
            }            
            Console.WriteLine($"\nmin = {min}");            
            Console.ReadKey();
        }
    }
}
