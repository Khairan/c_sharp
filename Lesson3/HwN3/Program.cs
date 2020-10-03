using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
//*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей.
//Написать программу, демонстрирующую все разработанные элементы класса.
//*Добавить свойства типа int для доступа к числителю и знаменателю;
//*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//***Добавить упрощение дробей.

namespace HwN3
{
    class Fractional
    {
        int num;
        int den;

        // Конструктор без параметров.
        public Fractional()
        {
            num = 1;
            den = 1;
        }

        // Конструктор, в котором задаем поля.    
        public Fractional(int num, int den)
        {
            this.num = num;
            if (den == 0) throw new ArgumentException("Знаменатель не может быть равен 0", "den");
            this.den = den;
        }

        static int NOK(int a, int b)
        {
            int a0 = a; int b0 = b;
            while (a != b)
                if (a < b) a = a + a0; else b = b + b0;
            return a;
        }

        static int NOD(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b; else b = b - a;
            return a;
        }

        //Сложение
        public Fractional Plus(Fractional x2)
        {
            Fractional x3 = new Fractional();
            x3.den = NOK(den, x2.den);
            x3.num = (num * (x3.den / den)) + (x2.num * (x3.den / x2.den));

            return x3;
        }

        //Вычитание
        public Fractional Minus(Fractional x2)
        {
            Fractional x3 = new Fractional();
            x3.den = NOK(den, x2.den);
            x3.num = (num * (x3.den / den)) - (x2.num * (x3.den / x2.den));
            return x3;
        }

        //Произведение
        public Fractional Multi(Fractional x2)
        {
            Fractional x3 = new Fractional();
            x3.den = den * x2.den;
            x3.num = num * x2.num;
            return x3;
        }

        //Деление
        public Fractional Div(Fractional x2)
        {
            Fractional x3 = new Fractional();
            x3.den = den * x2.num;
            x3.num = num * x2.den;
            return x3;
        }
                      
        //Числитель
        public int Num
        {
            get { return num; }
            set
            {
                num = value;
            }
        }

        //Знаменатель
        public int Den
        {
            get { return den; }
            set
            {
                den = value;
            }
        }

        //Десятичная дробь числа
        public double Decimal
        {
            get { return (double)num/den; }
            
        }

        //упрощение
        public void Simplification()
        {
             int nod = NOD(num, den);
            den /= nod;
            num /= nod;
        }       

        // Специальный метод, который возвращает строковое представление данных.
        public override string ToString()
        {
            return $"{num}/{den}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Класс дробей - Fractional\n");

            Fractional fract1 = new Fractional(2, 4);
            Console.WriteLine($"fract1: {fract1.ToString()}");
            Console.WriteLine($"Числитель: {fract1.Num} Знаменатель: {fract1.Den}");
            Console.WriteLine($"Десятичная дробь числа: {fract1.Decimal}");


            Fractional fract2 = new Fractional(1, 5);
            Console.WriteLine($"\nfract2: {fract2.ToString()}");
            Console.WriteLine($"Числитель: {fract2.Num} Знаменатель: {fract2.Den}");
            Console.WriteLine($"Десятичная дробь числа: {fract2.Decimal}");

            Fractional result = fract1.Plus(fract2);
            Console.WriteLine($"\nСложение: {result.ToString()}");
            result.Simplification();
            Console.WriteLine($"Упрощение: {result.ToString()}");

            result = fract1.Minus(fract2);
            Console.WriteLine($"\nВычитание: {result.ToString()}");
            result.Simplification();
            Console.WriteLine($"Упрощение: {result.ToString()}");

            result = fract1.Multi(fract2);
            Console.WriteLine($"\nУмножение: {result.ToString()}");
            result.Simplification();
            Console.WriteLine($"Упрощение: {result.ToString()}");

            result = fract1.Div(fract2);
            Console.WriteLine($"\nДеление: {result.ToString()}");
            result.Simplification();
            Console.WriteLine($"Упрощение: {result.ToString()}");

            Console.ReadKey();
        
        }
    }
}
