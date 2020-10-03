using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.

namespace HwN1
{
    class ComplexClass
    {
        double re;
        double im;        

        // Конструктор без параметров.
        public ComplexClass()
        {
            re = 0;
            im = 0;            
        }
        
        // Конструктор, в котором задаем поля.    
        public ComplexClass(double re, double im)
        {
            this.re = re;
            this.im = im;            
        }
        
        //Сложение
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = re + x2.re;
            x3.im = im + x2.im;
            return x3;
        }

        //Вычитание
        public ComplexClass Minus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = re - x2.re;
            x3.im = im - x2.im;
            return x3;
        }

        //Произведение
        public ComplexClass Multi(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = re * x2.re - im * x2.im;
            x3.im = re * x2.im + im * x2.re;
            return x3;
        }

        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {                
                im = value;
            }
        }

        public double Re
        {
            get { return re; }
            set
            {
                re = value;
            }
        }

        // Специальный метод, который возвращает строковое представление данных.
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    struct Complex
    {
        public double re;
        public double im;
        
        //Сложение
        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;            
            return y;
        }
        //Вычитание
        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;            
            return y;
        }
        //Произведение
        public Complex Multi(Complex x)
        {
            Complex y;
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;            
            return y;
        }
        //Представление строкой
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Структура Complex

            Console.WriteLine("Структура Complex"); 

            Complex complex1;
            complex1.re = 6;
            complex1.im = 8;
            Console.WriteLine($"complex1: {complex1.ToString()}");

            Complex complex2;
            complex2.re = 2;
            complex2.im = 4;
            Console.WriteLine($"complex2: {complex2.ToString()}");

            Complex result = complex1.Plus(complex2);
            Console.WriteLine($"Сложение: {result.ToString()}");

            result = complex1.Minus(complex2);
            Console.WriteLine($"Вычитание: {result.ToString()}");

            result = complex1.Multi(complex2);
            Console.WriteLine($"Умножение: {result.ToString()}");

            #endregion

            #region Класс ComplexClass

            Console.WriteLine("\nКласс ComplexClass");

            ComplexClass complex3 = new ComplexClass(10, 8);
            Console.WriteLine($"complex3: {complex3.ToString()}");
            
            ComplexClass complex4 = new ComplexClass(4, 4);
            Console.WriteLine($"complex4: {complex4.ToString()}");            

            int caseSwitch; bool f;
            Console.WriteLine("\nВыберите операцию работы с классом: 1 - сложение, 2 - вычитание, 3 - умножение.");           
            
            do
            {
                Console.Write("Введите номер операции: ");
                f = int.TryParse(Console.ReadLine(), out caseSwitch);

            } while (!f);

            switch (caseSwitch)
            {
                case 1:
                    var result1 = complex3.Plus(complex4);
                    Console.WriteLine($"Сложение: {result1.ToString()}");
                    break;
                case 2:
                    result1 = complex3.Minus(complex4);
                    Console.WriteLine($"Вычитание: {result1.ToString()}");
                    break;
                case 3:
                    result1 = complex3.Multi(complex4);
                    Console.WriteLine($"Умножение: {result1.ToString()}");
                    break;
                default:
                    Console.WriteLine("Нет такой операции");
                    break;
            }

            #endregion

            Console.ReadKey();

        }
    }
}
