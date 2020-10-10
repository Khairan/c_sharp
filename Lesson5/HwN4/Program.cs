using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
//№4
// *Задача ЕГЭ.
//На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
//В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
//< Фамилия > < Имя > < оценки >,
//где < Фамилия > — строка, состоящая не более чем из 20 символов, 
//<Имя> — строка, состоящая не более чем из 15 символов,
//<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
//<Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
//Иванов Петр 4 5 3
//Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
//Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

namespace HwN4
{

    class Program
    {
        static void Main(string[] args)
        {

            var appArray = new StudentsArray(@"D:\Документы\Game Dev\GeekBrains\C#\Lesson5\ConsoleAppLesson5\apprentices.txt");
            var worstStudents = new StudentsArray(3);
            for (int i = 0; i < appArray.GetLength(); i++)
            {
                appArray[i].Print();                
            }

            Console.WriteLine("\nХудшие ученики: ");
            appArray.BubbleSort();
            double badScore = appArray[2].Score;
            for (int i = 0; i < appArray.GetLength(); i++)
            {
                if (appArray[i].Score <= badScore) appArray[i].Print();
            }

            Console.ReadKey();

        }
    }
}
