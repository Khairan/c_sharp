using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Practice
{    
    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double Fun(double x);

    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        static void printDirect(DirectoryInfo dir)
        {
            Console.WriteLine("***** " + dir.Name + " *****");
            Console.WriteLine("FullName: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes.ToString());
            Console.WriteLine("Root: {0}", dir.Root);
        }

        class Student
        {
            public string lastName;
            public string firstName;
            public string university;
            public string faculty;
            public int course;
            public string department;
            public int group;
            public string city;
            int age;
            // Создаем конструктор
            public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                this.university = university;
                this.faculty = faculty;
                this.department = department;
                this.course = course;
                this.age = age;
                this.group = group;
                this.city = city;
            }
        }

        static int MyDelegat(Student st1, Student st2) // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(st1.firstName, st2.firstName); // Сравниваем две строки
        }

        static void Save(string fileName, int n)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            uint a0 = 0;                                      // uint - занимает 4 байта
            uint a1 = 1;
            uint a = a1;
            bw.Write(a0);
            bw.Write(a1);
            for (int i = 2; i < n; i++)
            {
                a = a0 + a1;
                bw.Write(a);
                a0 = a1;
                a1 = a;
            }
            fs.Close();
            bw.Close();
        }
        static void Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            for (int i = 1; i <= fs.Length / 4; i++) // uint занимает 4 байта
            {
                uint a = br.ReadUInt32();
                if (i % 3 == 0) Console.WriteLine("{0,3} {1}", i, a);
            }
            br.Close();
            fs.Close();
        }

        static void Save2(string fileName, int n)
        {
            Random rnd = new Random();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 1; i < n; i++)
            {
                bw.Write(rnd.Next(0, 10000));      // int занимает 4 байта
            }
            fs.Close();
            bw.Close();
        }
        static void Load2(string fileName)
        {
            DateTime d = DateTime.Now;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int[] a = new int[fs.Length / 4];
            for (int i = 0; i < fs.Length / 4; i++)    // int занимает 4 байта
            {
                a[i] = br.ReadInt32();
            }
            br.Close();
            fs.Close();
            int max = 0;
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length; j++)
                    if (Math.Abs(i - j) >= 8 && (long)(a[i] * a[j]) > max) max = a[i] * a[j];
            Console.WriteLine(max);
            Console.WriteLine(DateTime.Now - d);
        }

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double LoadFunc(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        static int Compare(int a, int b)
        {
            if (a % 10 > b % 10) return 1;
            if (a % 10 < b % 10) return -1;
            return 0;
        }

        static long FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static long BufferedStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        static void Main(string[] args)
        {
            #region Type byte
            //byte a;
            //Console.Write("Введите значение формата byte:");
            //if (byte.TryParse(Console.ReadLine(), out a)) Console.WriteLine($"a = {a}");
            //else Console.WriteLine($"Неверный формат данных");
            #endregion

            #region Делегаты
            //// Создаем новый делегат и передаем ссылку на него в метод Table
            //Console.WriteLine("Таблица функции MyFunc:");
            //// Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            //Table(new Fun(MyFunc), -2, 2);
            //Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            //// Упрощение(c C# 2.0).Делегат создается автоматически.            
            //Table(MyFunc, -2, 2);
            //Console.WriteLine("Таблица функции Sin:");
            //Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
            //Console.WriteLine("Таблица функции x^2:");
            //// Упрощение(с C# 2.0). Использование анонимного метода
            //Table(delegate (double x) { return x * x; }, 0, 3);
            #endregion

            #region Байтовый поток

            //try
            //{
            //    FileStream fileIn = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            //    FileStream fileOut = new FileStream("newData.txt", FileMode.Create, FileAccess.Write);
            //    int i;
            //    while ((i = fileIn.ReadByte()) != -1)
            //    {
            //        //  запись очередного байта в поток, связанный с файлом fileOut
            //        fileOut.WriteByte((byte)i);
            //    }
            //    fileIn.Close();
            //    fileOut.Close();
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine(exc.Message);
            //}
            //Console.WriteLine("Файл успешно скопирован");

            #endregion

            #region Символьный поток
            //StreamReader fileIn = new StreamReader("hobbit.txt");
            //StreamWriter fileOut = new StreamWriter("numbers.txt", false);
            //string text = fileIn.ReadToEnd();
            //Regex r = new Regex(@"[-+]?\d+");
            //Match integer = r.Match(text);
            //while (integer.Success)
            //{
            //    Console.WriteLine(integer);
            //    fileOut.WriteLine(integer);
            //    integer = integer.NextMatch();
            //}
            //fileIn.Close();
            //fileOut.Close();            
            #endregion

            #region Двоичные потоки
            //FileStream f = new FileStream("data.bin", FileMode.Open);
            //BinaryReader fIn = new BinaryReader(f);
            //long n = f.Length / 4; // определяем количество чисел в двоичном потоке
            //int a;
            //for (int i = 0; i < n; i++)
            //{
            //    a = fIn.ReadInt32();
            //    Console.Write(a + " ");
            //}
            //fIn.Close();
            //f.Close();
            #endregion

            #region Класс DirectoryInfo                        
            //DirectoryInfo dir = new DirectoryInfo(@"C:\");
            //printDirect(dir);
            //DirectoryInfo[] subDirects = dir.GetDirectories();
            //Console.WriteLine("Найдено {0} подкаталогов", subDirects.Length);
            //foreach (DirectoryInfo d in subDirects)
            //{
            //    printDirect(d);
            //}
            #endregion

            #region Коллекции - необобщённые списки
            //int bakalavr = 0;
            //int magistr = 0;
            //// Создадим необобщенный список
            //List<string> list = new List<string>();
            //// Запомним время в начале обработки данных
            //DateTime dt = DateTime.Now;
            //StreamReader sr = new StreamReader("students_1.csv", Encoding.GetEncoding(1251));
            //while (!sr.EndOfStream)
            //{
            //    try
            //    {
            //        string[] s = sr.ReadLine().Split(';');
            //        // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
            //        list.Add(s[1] + " " + s[0]);// Добавляем склееные имя и фамилию
            //        if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
            //    }
            //    catch
            //    {
            //    }
            //}
            //sr.Close();
            //list.Sort();
            //Console.WriteLine("Всего студентов:{0}", list.Count);
            //Console.WriteLine("Магистров:{0}", magistr);
            //Console.WriteLine("Бакалавров:{0}", bakalavr);
            //foreach (var v in list) Console.WriteLine(v);
            //// Вычислим время обработки данных
            //Console.WriteLine(DateTime.Now - dt);
            #endregion

            #region Коллекции - обобщённые списки
            //int bakalavr = 0;
            //int magistr = 0;
            //List<Student> list = new List<Student>(); // Создаем список студентов
            //DateTime dt = DateTime.Now;
            //StreamReader sr = new StreamReader("students_1.csv", Encoding.GetEncoding(1251));
            //while (!sr.EndOfStream)
            //{
            //    try
            //    {
            //        string[] s = sr.ReadLine().Split(';');
            //        // Добавляем в список новый экземпляр класса Student
            //        list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
            //        // Одновременно подсчитываем количество бакалавров и магистров
            //        if (int.Parse(s[5]) < 5) bakalavr++; else magistr++;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //        Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
            //        // Выход из Main
            //        if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            //    }
            //}
            //sr.Close();
            //list.Sort(new Comparison<Student>(MyDelegat));
            //Console.WriteLine("Всего студентов:" + list.Count);
            //Console.WriteLine("Магистров:{0}", magistr);
            //Console.WriteLine("Бакалавров:{0}", bakalavr);
            //foreach (var v in list) Console.WriteLine(v.firstName);
            //Console.WriteLine(DateTime.Now - dt);
            #endregion

            #region Задача 1. Последовательность Фибоначчи
            //Save("data.bin", 33);
            //Load("data.bin");            
            #endregion

            #region Задача 2. Сложная задача ЕГЭ
            //Save2("data.bin", 10000);
            //Load2("data.bin");            
            #endregion

            #region Задача 3. Минимум функции
            //SaveFunc("data.bin", -100, 100, 0.5);
            //Console.WriteLine(LoadFunc("data.bin"));
            #endregion

            #region Задача 4. Сканер
            //// Получаем список файлов в папке. AllDirectories - сканировать также и подпапки
            //string[] fs = Directory.GetFiles("temp", "*.*", SearchOption.AllDirectories);
            //// Просматриваем каждый файл в массиве
            //foreach (var filename in fs)
            //{
            //    // Создаем регулярное выражения дя поиска почтовых адресов
            //    Regex regex = new Regex(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})");
            //    // Считываем файл
            //    string s = File.ReadAllText(filename);
            //    Console.WriteLine(filename);
            //    // Выводим найденные адреса на экран
            //    foreach (var c in regex.Matches(s))
            //        Console.Write("{0} ", c);
            //}
            #endregion

            #region Пример делегата
            //int[] a = new int[20];
            //for (int i = 0; i < a.Length; i++)
            //    a[i] = i;
            //Array.Sort(a, Compare);
            //foreach (var el in a)
            //{
            //    Console.Write("{0,4}", el);
            //}
            #endregion

            #region Пример записи файла различными способами
            //long kbyte = 1024;
            //long mbyte = 1024 * kbyte;
            //long gbyte = 1024 * mbyte;
            //long size = mbyte;
            
            //Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("bigdata0.bin", size));
            //Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("bigdata1.bin", size));
            //Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("bigdata2.bin", size));
            //Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("bigdata3.bin", size));
            #endregion

            Console.ReadKey();

        }
    }
}
