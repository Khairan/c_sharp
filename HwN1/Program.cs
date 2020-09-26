using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей №1
//Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

namespace HwN1
{
    public class Program
    {
        public static void Signature()
        {
            Console.WriteLine($"\nCopyright (©) Glotov Andrei. {DateTime.Now.Year}");
            Console.ReadKey();
        }

        public static string ParamRequest(string paramName)
        {
            // Запрашиваем параметр анкеты и возвращаем ответ
            Console.Write($"Введите {paramName}: ");
            return Console.ReadLine();
        }

        static void Main()
        {
            Console.WriteLine("Анкета.");
            string name = ParamRequest("Имя");
            string surname = ParamRequest("Фамилию");
            string age = ParamRequest("Возраст");
            string height = ParamRequest("Рост");
            string weight = ParamRequest("Вес");            

            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight); // склеивание
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, surname, age, height, weight); // форматированный вывод
            Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age} Рост: {height} Вес: {weight}"); // вывод со знаком $

            Signature();
        }
    }
}
