using System;

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
    class Student
    {
        string name;
        string surname;
        int[] grades;
        double score;

        public Student()
        {
            name = string.Empty;
            surname = string.Empty;
            grades = new int[0];
            score = 0;
        }

        public Student(string name, string surname, int[] grades)
        {
            this.name = name;
            this.surname = surname;
            this.grades = grades;
            score = this.AverageScore();
        }

        public Student(string msg)
        {
            string[] parts = msg.Split(' ');
            this.name = parts[0];
            this.surname = parts[1];
            grades = new int[parts.Length - 2];

            for (int i = 2; i < parts.Length; i++)
            {
                grades[i - 2] = int.Parse(parts[i]);
            }

            score = this.AverageScore();

        }        

        public void Print()
        {
            Console.WriteLine($"{name} {surname} {String.Join(" ", grades)} Средний балл: {score}");
        }

        double AverageScore()
        {
            int sum = 0;
            foreach (int g in grades)
            {
                sum += g;    
            }
            return Math.Round((double)sum / grades.Length,2);
        }

        public double Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int[] Grades
        {
            get { return grades; }
            set { grades = value; }
        }       

    }
}
