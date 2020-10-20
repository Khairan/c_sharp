using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

//Тут просто практика из методички

namespace Practice
{
    [Serializable]
    public class Student
    {
        // Чтобы поля можно было сериализовать, они должны быть открытыми 
        public string firstName;
        public string lastName;
        // Если поле не открыто, оно не будет сериализоваться
        int age;
        // Если мы хотим не нарушать принцип инкапсуляции и при этом сериализовать поле, то должны реализовать доступ к нему через публичное свойство        
        public int Age
        {
            get { return age; }
            set { if (value > 0) age = value; }
        }
        // Если есть отличный от конструктора по умолчанию конструктор, то пустой конструктор автоматически не создается
        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        //...в этом случае для сериализации требуется самим создать пустой конструктор
        public Student()
        {
        }
    }

    class Program
    {        

        static void SaveAsXmlFormat(Student obj, string fileName)
        {
            // Сохранить объект класса Student в файле fileName в формате XML
            // typeof(Student) передает в XmlSerializer данные о классе.
            // Внутри метода Serialize происходит большая работа по постройке
            // графа зависимостей для последующего создания xml-файла.
            // Процесс получения данных о структуре объекта называется рефлексией.
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Student));
            // Создаем файловый поток(проще говоря, создаем файл)
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            // В этот поток записываем сериализованные данные(записываем xml-файл)
            xmlFormat.Serialize(fStream, obj);
            fStream.Close();
        }
        
        static Student LoadFromXmlFormat(string fileName)
        {
            Student obj = new Student();
            // Считать объект Student из файла fileName формата XML
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Student));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            obj = (xmlFormat.Deserialize(fStream) as Student);
            fStream.Close();
            return obj;
        }

        static void SaveAsXmlFormat(List<Student> obj, string fileName)
        {
            // Сериализовать список объектов не представляется большой проблемой
            // Дело в том, что все объекты в C# наследуются от класса Object,
            // который представляет собой дерево объектов
            // подробней читайте у Эндрю Троелсена “Язык программирования C# 5.0”
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            // Создаем файловый поток (проще говоря, создаем файл)
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            // В этот поток записываем сериализованные данные (записываем xml-файл)
            xmlFormat.Serialize(fStream, obj);
            fStream.Close();
        }
        
        static void LoadFromXmlFormat(ref List<Student> obj, string fileName)
        {
            // Считать класс List<Student> из файла fileName формата XML
            // Обратите внимание, что этот пример показывает нам, что List<Student> не более, чем класс, его структура более сложная и для ее понимания потребуется некоторый опыт
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            obj = (List<Student>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static void Main(string[] args)
        {
            #region GetType, typeof 1
            //// Используется для получения объекта System.Type для типа.
            //// Выражение typeof принимает следующую форму:
            //Type type = typeof(int);
            //Console.WriteLine(type);
            //// Для получения типа выражения во время выполнения можно 
            //// воспользоваться методом платформы.NET GetType, как показано в следующем примере:
            //int i = 0;
            //Type type2 = i.GetType();
            //Console.WriteLine(type2);
            #endregion

            #region GetType, typeof 2
            //DateTime dateTime = new DateTime();            
            ////dateTime.DayOfWeek
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanRead);
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanWrite);
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null));            
            #endregion

            #region Сериализация и десериализация
            //Student student = new Student();
            //student.Age = 20;
            //student.firstName = "Иван";
            //student.lastName = "Иванов";
            //SaveAsXmlFormat(student, "data.xml");
            //student = LoadFromXmlFormat("data.xml");
            //Console.WriteLine("{0} {1} {2}", student.firstName, student.lastName, student.Age);
            #endregion

            #region Сериализация массива или коллекции
            //List<Student> list = new List<Student>();
            //list.Add(new Student("Иван", "Иванов", 20));
            //list.Add(new Student("Петр", "Петров", 21));
            //SaveAsXmlFormat(list, "data.xml");
            //LoadFromXmlFormat(ref list, "data.xml");
            //foreach (var v in list) Console.WriteLine("{0} {1} {2}", v.firstName, v.lastName, v.Age);
            #endregion

            Console.ReadKey();

        }
    }
}
