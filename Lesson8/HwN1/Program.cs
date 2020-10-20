using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//глотов Андрей
//Задание №1
//С помощью рефлексии выведите все свойства структуры DateTime

namespace HwN1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            var dateTimeType = dateTime.GetType();
            Console.WriteLine($"Тип данных: {dateTimeType.ToString()}");
            foreach (var item in dateTimeType.GetProperties())
            {
                Console.WriteLine($"Свойство: {item.Name, 12}   тип: {item.PropertyType, 20}");
            }
            
            Console.ReadKey();
        }
    }
}
