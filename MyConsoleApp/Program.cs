using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Здесь я выполнял практику из методички, домашнее задание в HwN1, HwN2 и т.д.

namespace MyConsoleApp
{
    class MyProgram
    {       
        static bool Odd(int n)
        {
            // Определение остатка от деления
            return n % 2 == 0; 
        }

        static void Print(string msg, int x, int y)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            // Установим цвет символов
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }

        static void Print(string msg, int x, int y, ConsoleColor foregroundcolor)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            
            // Установим цвет символов
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
            // Вернем цвет обратно к белому
            Console.ForegroundColor = ConsoleColor.White;
        }

        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && c + b > a;
        }

        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        static void Main() //точка входа
        {

            #region Пример 7

            //double d = 123321.12345;
            //Console.WriteLine($"{d:f2}");
            //Console.WriteLine($"{d:f4}");
            //Console.WriteLine($"{d}");
            //Console.WriteLine($"{d.ToString("### ### ### ###.### ### ###")}");

            #endregion

            #region Пример 6

            //            Console.WriteLine(@"Привет
            //Привет
            //Привет
            //Привет
            //Привет
            //Привет");
            //            //Console.WriteLine("Привет\nПривет\nПривет\nПривет\nПривет\nПривет");
            //            //Console.WriteLine("Привет");
            //            //Console.WriteLine("Привет");
            //            //Console.WriteLine("Привет");
            //            //Console.WriteLine("Привет");

            #endregion

            #region Пример 5

            //Console.WriteLine($"{1} & {3} = {1 & 3}");
            //Console.WriteLine($"{2} | {5} = {2 | 5}");
            //Console.WriteLine($"{4} ^ {7} = {4 ^ 7}");
            //Console.WriteLine($"{5}>> 2 = {5 >> 2}");
            //Console.WriteLine($"{5}<< 2 = {5 << 2}");

            //string s = null;

            //bool f = s != null && s[0] == 'C';

            //f = s == null || s[0] == 'C';


            //Console.WriteLine(f);

            //Console.WriteLine($"{true,-5} && {true,-5} = {true && true}");
            //Console.WriteLine($"{true,-5} && {false,-5} = {true && false}");
            //Console.WriteLine($"{false,-5} && {true,-5} = {false && true}");
            //Console.WriteLine($"{false,-5} && {false,-5} = {false && false}");

            //Console.WriteLine();

            //Console.WriteLine($"{true,-5} & {true,-5} = {true & true}");
            //Console.WriteLine($"{true,-5} & {false,-5} = {true & false}");
            //Console.WriteLine($"{false,-5} & {true,-5} = {false & true}");
            //Console.WriteLine($"{false,-5} & {false,-5} = {false & false}");

            //// && 
            ///
            //// || 
            //// !
            //// ^ 
            ///


            ////bool f = 1 < 3 && 4 == 4; Console.WriteLine(f);
            //// true = 1
            //// false = 0
            //// 
            //Console.WriteLine($"{true,-5} && {true,-5} = {true && true}");
            //Console.WriteLine($"{true,-5} && {false,-5} = {true && false}");
            //Console.WriteLine($"{false,-5} && {true,-5} = {false && true}");
            //Console.WriteLine($"{false,-5} && {false,-5} = {false && false}");


            //Console.WriteLine($"{true,-5} || {true,-5} = {true || true}");
            //Console.WriteLine($"{true,-5} || {false,-5} = {true || false}");
            //Console.WriteLine($"{false,-5} || {true,-5} = {false || true}");
            //Console.WriteLine($"{false,-5} || {false,-5} = {false || false}");


            //Console.WriteLine($"{true,-5} ^ {true,-5} = {true ^ true}");
            //Console.WriteLine($"{true,-5} ^ {false,-5} = {true ^ false}");
            //Console.WriteLine($"{false,-5} ^ {true,-5} = {false ^ true}");
            //Console.WriteLine($"{false,-5} ^ {false,-5} = {false ^ false}");

            //Console.WriteLine($"!{true,-5} = {!true}");
            //Console.WriteLine($"!{false,-5} ^ {!false,-5}");

            #endregion

            #region Пример 4

            //bool b = true;
            //Console.WriteLine(b);
            //b = 1 > 5 ;
            //// && 
            //// || 
            //// !
            //// ^ 
            //b = DateTime.Now.Day == 22 && DateTime.Now.Hour > 22;
            //Console.WriteLine(b);

            //char c = '!';
            //c = Console.ReadKey(true).KeyChar;
            //Console.WriteLine($"Нажата {c}");
            //Console.WriteLine(c);

            //string address = "Смоленск Ул. Урицкого д 13"; 
            //Console.WriteLine(address);
            //Console.WriteLine(address);
            //Console.WriteLine(address);
            //Console.WriteLine(address);
            //Console.WriteLine(address);
            //Console.WriteLine(address);

            //float f;
            //f = 1.3f;
            //Console.WriteLine(f);

            //decimal dec = 123.456m;
            //Console.WriteLine(dec);

            //sbyte sb = -120; // -128 .. 127

            //int i = 10;

            //Console.WriteLine($"sb = {sb}");
            //Console.WriteLine($"i = {i}");

            ////i = sb;
            ////i = Convert.ToInt32(sb);
            ////i = (int)sb;

            ////Console.WriteLine($"sb = {sb}");
            ////Console.WriteLine($"i = {i}");

            //sb = Convert.ToSByte(i);

            //Console.WriteLine(address);
            //Console.WriteLine(address);
            //Console.WriteLine(address);

            //Console.WriteLine($"sb = {sb}");
            //Console.WriteLine($"i = {i}");


            //double d = 22.9430;

            //i = Convert.ToInt32(d); // 0
            //Console.WriteLine($"d = {d}   i = {i}");
            //d = i;
            //Console.WriteLine($"d = {d}   i = {i}");

            #endregion

            #region Пример 3

            //Console.Write("Введите первое число: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{a} + {b} = {a + b}");
            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //Console.WriteLine(a + " + " + b + " = " + (a + b));
            //Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString());
            //Console.WriteLine(Convert.ToString(a) + " + " + Convert.ToString(b) + " = " + Convert.ToString(a + b));


            #endregion

            #region Пример 2

            //Console.Write("Введите имя: ");
            //var name = Console.ReadLine();
            //Console.WriteLine("Привет, " + name + "!");
            //Console.WriteLine($"Привет, {name}!");
            //Console.WriteLine("Привет, {0}!", name);

            //var pat = String.Format("Привет, {0}!", name);
            //Console.WriteLine(pat);

            #endregion

            #region Пример 1


            //Console.WriteLine("Hello world!"); // вывод на экран консоли
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5
            //Console.WriteLine("Hello world!"); // f5 или ctrl+f5


            #endregion


            #region Практика 1 - Написать программу сложения двух чисел.

            //double x;
            //double y;
            //Console.Write("Введите первое число: ");
            //string str = Console.ReadLine();
            //x = Convert.ToDouble(str);
            //Console.Write("Введите второе число: ");
            //y = Convert.ToDouble(Console.ReadLine());
            //double z = x + y;
            //Console.WriteLine(x + "+" + y + "=" + z); //Преобразование в строку

            #endregion

            #region Практика 2  - Вывести значение функции ax^2+bx+c в точке x. x — ввести с клавиатуры, a,b и c — присвоить в программе.

            //double a = 1;
            //double b = 1;
            //double c = 1;
            //double x;
            //Console.Write("Введите значение x: ");
            //string s = Console.ReadLine();
            //x = Convert.ToDouble(s);
            //double f = a * Math.Pow(x, 2) + b * x + c;
            //Console.WriteLine("{0}*x^2+{1}*x+{2}, при x={3}, f={4}", a, b, c, x, f);

            #endregion

            #region Практика 3 - Обменять значениями две переменные.

            //int a = 10;     // Присваиваем начальное значение
            //int b = 20;     // Присваиваем начальное значение
            //int t = a;        // В t запоминаем значение a
            //a = b;           // В a записываем b
            //b = t;           // В b записываем сохраненное a

            #endregion

            #region Практика 4 - Разработать метод проверки чётности числа. Метод возвращает true, если число чётное, и false, если число нечётное.

            //// int value = 100500;
            //Console.Write("Введите число для определения четности числа: ");
            //int value = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Odd(value));

            #endregion

            #region Практика 5 - Работа с консолью и перегрузкой методов.

            //Print("Привет!", 1, 1);
            //Print("Привет еще раз!", ConsoleColor.Red);
            //Print("Привет в третий раз!", 3, 3, ConsoleColor.Blue);

            #endregion

            #region Практика 6 - Написать программу для подсчета площади треугольника.

            Console.Write("Введите a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Может существовать треугольник с такими сторонами:" + IsTriangle(a, b, c));
            Console.WriteLine("Площадь треугольника:" + S(a, b, c));

            #endregion

            Console.ReadKey();
        }
                
    }
}
