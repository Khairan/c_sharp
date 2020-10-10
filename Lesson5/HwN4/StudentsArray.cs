using System;
using System.IO;

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
    class StudentsArray
    {
        Student[] array;

        public StudentsArray(int n)
        {
            array = new Student[n];
        }

        public StudentsArray(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename);
                //  Считываем количество учеников
                int n = int.Parse(sr.ReadLine());
                array = new Student[n];
                //  Считываем массив
                for (int i = 0; i < n; i++)
                {
                    array[i] = new Student(sr.ReadLine());
                }
                sr.Close();                
            }
            else Console.WriteLine("Error load file");
        }

        public int GetLength()
        {
            return array.Length;
        }

        public void BubbleSort()
        {
            //  Сортируем методом пузырька
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j].Score > array[j + 1].Score)//Сравниваем соседние элементы
                    {
                        //  Обмениваем элементы местами
                        var t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
        }

        public Student this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

    }
}
