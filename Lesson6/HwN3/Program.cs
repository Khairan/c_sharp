using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Глтов Андрей
//Задача №3
//Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
//в) отсортировать список по возрасту студента;
//г) *отсортировать список по курсу и возрасту студента;

namespace HwN3
{
    class Program
    {
        static int SortAge(Student st1, Student st2) // Создаем метод для сравнения для экземпляров
        {
            return st1.age.CompareTo(st2.age);            
        }

        static int SortCourse(Student st1, Student st2)
        {
            return st1.course.CompareTo(st2.course);           
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
            public int age;
            
            // Создаем конструктор
            public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
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

            static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int[] ageArray = new int[100];
            
            List<Student> list = new List<Student>(); // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_1.csv", Encoding.GetEncoding(1251));
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    int age = int.Parse(s[5]);
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], age, int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                    ageArray[age]++; //заполнение частотного массива
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            list.Sort(SortAge);
            list.Sort(SortCourse);            
            Console.WriteLine("Всего студентов: " + list.Count);
            Console.WriteLine("Бакалавров(1-4 курс): {0}", bakalavr);
            Console.WriteLine("Магистров(5-6 курс): {0}\n", magistr);
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.lastName} возраст {v.age} курс {v.course}");
            int youngStudents = 0;
            for (int i = 18; i <= 20; i++)
            {
                youngStudents += ageArray[i];
            }
            Console.WriteLine($"\nСтуденты в возрасте от 18 до 20 лет: {youngStudents}");
            Console.WriteLine($"\n{DateTime.Now - dt}");
            Console.ReadKey();
        }
    }
}
