using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

//Практика по методичке

namespace Practice
{
    #region Static
    class MyClass
    {
        public static int static_a;
        public int non_static_a;
    }
    #endregion

    #region ComplexClass2
    class ComplexClass2
    {
        // Поля приватные.
        private double im;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double re;

        // Конструктор без параметров.
        public ComplexClass2()
        {
            im = 0;
            re = 0;
        }

        // Конструктор, в котором задаем поля.    
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public ComplexClass2(double _im, double re)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
        }
        public ComplexClass2 Plus(ComplexClass2 x2)
        {
            ComplexClass2 x3 = new ComplexClass2();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }
        // Специальный метод, который возвращает строковое представление данных.
        override public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    #endregion

    #region ComplexClass1
    class ComplexClass1
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public ComplexClass1 Plus(ComplexClass1 x2)
        {
            ComplexClass1 x3 = new ComplexClass1();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        override public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    #endregion

    #region struct Complex
    struct Complex
    {
        public double im;
        public double re;
        //  в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        override public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    #endregion

    #region Задача 3. Решение с использованием ООП.
    class Table
    {
        double a = -5;
        double b = 5;
        double h = 0.5;

        public Table()
        {
        }
        public Table(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }

        double F(double x)
        {
            return 1 / x;
        }

        public void Show(double a, double b, double h)
        {
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }
        }
        public void Show()
        {
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }
        }
    }
    #endregion

    class Program
    {
        #region ChangeSign     
        static void ChangeSign(ref int a, ref int b, ref int c)
        {
            a = -a;
            b = -b;
            c = -c;
        }
        #endregion

        #region Swap        
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        #endregion

        #region TryParse
        static int value;
        static string console_message = "Введите число:";
        
        static int GetValue(string message)        
        {
            int x;
            string s;
            bool flag;       // Логическая переменная, выступающая в роли "флага". 
                             // Истинно (флаг поднят), ложно (флаг опущен)
            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                //  Если перевод произошел неправильно, то результатом будет false
                flag = int.TryParse(s, out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
        
        static void ShowValue(string description)
        {
            Console.WriteLine(description + value);
        }
        
        static int ReturnValue()
        {
            ShowValue("ReturnValue (до): ");
            int tmp = 10;
            ShowValue("ReturnValue (после): ");
            return tmp;
        }
        
        static void OutParameter(out int tmp)
        {
            ShowValue("OutParameter (до): ");
            tmp = 10;
            ShowValue("OutParameter (после): ");
        }
        #endregion

        #region Задача 3. Решение без использования ООП. 
        static double F(double x)
        {
            return 1 / x;
        }
        #endregion

        #region Структура Point
        struct Point
        {
            double _x, _y;

            public Point(double x, double y)
            {
                _x = x;
                _y = y;
            }

            public double Distance(Point Z)
            {
                return Math.Sqrt(Math.Pow(_x - Z._x, 2) + Math.Pow(_y - Z._y, 2));
            }
        }
        #endregion

        #region Класс Point
        class Point1
        {
            double _x, _y;

            public Point1()
            {
                _x = _y = 0;
            }
            public Point1(double x, double y)
            {
                _x = x;
                _y = y;
            }
            public void SetX(double value)
            {
                _x = value;
            }
            public double GetX()
            {
                return _x;
            }
            public double X
            {
                get { return _x; }
                set
                {
                    if (value > 0) _x = value;
                    else _x = -value;
                }
            }
            public double Y
            {
                get { return _y; }
                set
                {
                    if (value > 0) _y = value;
                    else _y = -value;
                }
            }
            public double Distance(Point1 Z)
            {
                return Math.Sqrt(Math.Pow(_x - Z._x, 2) + Math.Pow(_y - Z._y, 2));
            }
            public override string ToString()
            {
                return _x + "," + _y;
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region ChangeSign            

            //int a = 10, b = 5, c = -7;
            //Console.WriteLine($"a = {a} b = {b} c = {c}");

            //ChangeSign(ref a, ref b, ref c);

            //Console.WriteLine($"a = {a} b = {b} c = {c}");

            #endregion

            #region Swap

            //int a = 10;
            //int b = 20;
            //Console.WriteLine("a={0} b={1}", a, b);
            //Swap(ref a, ref b);// Пример вызова
            //Console.WriteLine("a={0} b={1}", a, b);

            #endregion

            #region TryParse

            //value = GetValue(console_message);
            //Console.WriteLine("Return ...");
            //value = ReturnValue();
            //ShowValue("value после ReturnValue(): ");

            //value = GetValue(console_message);
            //Console.WriteLine("Out parameter ...");
            //OutParameter(out value);
            //ShowValue("value после OutParameter(): ");

            #endregion

            #region Complex

            //Complex complex1;
            //complex1.re = 1;
            //complex1.im = 1;

            //Complex complex2;
            //complex2.re = 2;
            //complex2.im = 2;

            //Complex result = complex1.Plus(complex2);
            //Console.WriteLine(result.ToString());
            //result = complex1.Multi(complex2);
            //Console.WriteLine(result.ToString());

            #endregion

            #region DateTime

            //DateTime start = DateTime.Now;
            //Console.WriteLine(start);
            //Thread.Sleep(2000);
            //DateTime finish = DateTime.Now;
            //Console.WriteLine(finish);
            //TimeSpan duration = finish - start;
            //Console.WriteLine(duration);
            //Console.WriteLine(finish - start);

            #endregion

            #region ComplexClass1

            //ComplexClass1 complex1 = new ComplexClass1();
            //complex1.re = 1;
            //complex1.im = 1;

            //ComplexClass1 complex2 = new ComplexClass1();
            //complex2.re = 2;
            //complex2.im = 2;

            //ComplexClass1 result = complex1.Plus(complex2);
            //Console.WriteLine(result.ToString());

            #endregion

            #region ComplexClass2

            //// Описали ссылку на объект.
            //ComplexClass2 complex1;
            //// Создали объект и сохранили ссылку на него в complex1.
            //complex1 = new ComplexClass2(1, 1);
            //// Описали объект и создали его.
            //ComplexClass2 complex2 = new ComplexClass2(2, 2);
            //// С помощью свойства Im изменили внутреннее (приватное) поле im.
            //complex2.Im = 3;            
            //// Создали ссылку на объект.
            //ComplexClass2 result;
            //// Так как в методе Plus создается новый объект,
            //// в result сохраняем ссылку на вновь созданный объект.
            //result = complex1.Plus(complex2);
            //Console.WriteLine(result.ToString());

            #endregion

            #region Static

            //MyClass.static_a = 10;            
            //MyClass myobj = new MyClass();
            //myobj.non_static_a = 10;

            #endregion

            #region Random

            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++) Console.Write("[{0,3}]", rnd.Next(0, 10));
            //Console.WriteLine();

            #endregion

            #region Задача 1. Найти максимальное число.

            //int a = int.Parse(Console.ReadLine());
            //int max = a;
            //while (a != 0)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    if (a > max) max = a;
            //}
            //Console.WriteLine(max);

            #endregion

            #region Задача 2. Вычислить частное q и остаток r при делении а на d, не используя операций деления (/) и взятия остатка от деления (%).

            //int a = 10;
            //int d = 3;
            //// a/d
            //int r = a, q = 0;
            //while (r >= d)
            //{
            //    r = r - d;
            //    q++;
            //}
            //Console.WriteLine("Частное {0}.\n Остаток {1}", q, r);

            #endregion

            #region Задача 3. Написать программу табуляции произвольной функции в диапазоне от a до b.  Решение без использования ООП.

            //double a = -5;
            //double b = 5;
            //double h = 0.5;
            //Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            //for (double x = a; x <= b; x = x + h)
            //{
            //    Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            //}

            #endregion

            #region Задача 3. Решение с использованием ООП.

            //Table table1 = new Table();
            //table1.Show();
            //Console.WriteLine("Для выполнения следующего расчета нажмите любую клавишу");
            //Console.ReadKey();
            //Table table2 = new Table(1, 2, 0.5);
            //table2.Show();

            #endregion

            #region Задача 4. Игра «Угадай число». Метод половинного деления.

            //int min = 1;
            //int max = 100;
            //int maxCount = (int)Math.Log(max - min + 1, 2) + 1;
            //int count = 0;
            //Random rnd = new Random();
            //int guessNumber = rnd.Next(min, max);
            //Console.WriteLine("Компьютер загадал число от {0} до {1}. Попробуйте угадать его за {2} попыток", min, max, maxCount);
            //int n;
            //do
            //{
            //    count++;
            //    Console.Write("{0} попытка. Введите число:", count);
            //    n = int.Parse(Console.ReadLine());
            //    if (n > guessNumber) Console.WriteLine("Перелет!");
            //    if (n < guessNumber) Console.WriteLine("Недолет!");
            //}
            //while (count < maxCount && n != guessNumber);
            //if (n == guessNumber) Console.WriteLine("Поздравляю! Вы угадали число за {0} попыток", count);
            //else Console.WriteLine("Неудача. Попробуйте еще раз");

            #endregion

            #region Структура Point

            //Point A = new Point(0, 0);
            //Point B = new Point(2, 2);
            //Console.WriteLine(A.Distance(B));

            #endregion

            #region Класс Point

            //Point1 C = new Point1();
            //C.SetX(10);
            //Console.WriteLine(C.GetX());
            //Console.WriteLine(C.X);
            //C.X = 20;
            //C.Y = -5;
            //Console.WriteLine(C);

            //Point1 A = new Point1();
            //Point1 B = new Point1(2, 2);
            //Console.WriteLine(A.Distance(B));
            
            #endregion

            Console.ReadKey();
        }
    }
}
