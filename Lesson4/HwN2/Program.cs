using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
//Задание №2
//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
//в)**Добавьте обработку ситуации отсутствия файла на диске.

namespace HwN2
{
    class Program
    {
        static class StaticClass
        {
            static bool Div3(int a)
            {
                return a % 3 == 0;
            }

            public static void FindDiv3(int[] storage)
            {
                int count = 0;
                int length = storage.Length;

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
            }

            public static void Print(int[] storage)
            {
                for (int i = 0; i < storage.Length; i++)
                {
                   Console.Write($"{storage[i],2}");
                   
                }

            }

            public static int[] ReadArray(string path)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int length = Convert.ToInt32(sr.ReadLine());                    
                    int[] storage = new int[length];

                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine();

                        string[] elements = s.Split(',');
                        for (int i = 0; i < length; i++)
                        {
                            storage[i] = Convert.ToInt32(elements[i]);
                        }

                    }
                    return storage;
                }

            }

        }

        static void Main(string[] args)
        {

            try
            {
                var storage = StaticClass.ReadArray("D:/Документы/Game Dev/GeekBrains/C#/Lesson4/ConsoleAppLesson4/array.txt");
                Console.WriteLine($"Массив из {storage.Length} элементов: ");
                StaticClass.Print(storage);
                StaticClass.FindDiv3(storage);
            }
            catch
            {
                Console.WriteLine("Не удалось открыть файл на диске!");
            }
                        
            Console.ReadKey();
           

        }
        
    }
}
