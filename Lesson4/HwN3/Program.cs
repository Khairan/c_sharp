using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
//Задание №3
//а) Дописать класс для работы с одномерным массивом.
//Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
//Создать свойство Sum, которое возвращает сумму элементов массива, 
//метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
//метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.

namespace HwN3
{
    class MyArray
    {
        private int[] storage;

        public MyArray(int size, int min, int step)
        {
            storage = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                storage[i] = min;
                min = min + step;
            }
        }

        public void Print()
        {
            for (int i = 0; i < storage.Length; i++)
            {
                Console.Write($"{storage[i],4}");
            }            
        }

        public void Print(int[] storage)
        {   
            for (int i = 0; i < storage.Length; i++)
            {   
                Console.Write($"{storage[i],4}");              
            }            
        }

        public void Multi(int mulipicator)
        {
            for (int i = 0; i < storage.Length; i++)
            {
                storage[i] *= mulipicator;
            }             
        }

        public int[] Inverse()
        {
            int[]  storage2 = new int[storage.Length];
            for (int i = 0; i < storage.Length; i++)
            {
                storage2[i] = -storage[i];
            }

            return storage2;
        }

        public int Sum
        {
            get {
                int sum = 0;
                    for (int i = 0; i < storage.Length; i++)
                    {
                        sum += storage[i];
                    }
                return sum; }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var myArray = new MyArray(5, 1, 3);
            myArray.Print();
            Console.WriteLine($"\nСумма элементов массива = {myArray.Sum}");
            
            Console.WriteLine("\nИнверсный массив");
            myArray.Print(myArray.Inverse());
            Console.WriteLine("\nОригинальный массив");
            myArray.Print();
            Console.WriteLine("\nУмноженный массив");
            myArray.Multi(2);
            myArray.Print();

            Console.ReadKey();


        }
    }
}
