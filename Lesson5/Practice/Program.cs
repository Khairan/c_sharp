using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Тут просто практика

namespace Practice
{
    class Program
    {
        static void PrintArray(string line, char[] a)
        {
            Console.WriteLine(line);
            foreach (char x in a) Console.Write(x);
            Console.WriteLine('\n');
        }

        static void PrintString(StringBuilder a)
        {
            Console.WriteLine("Строка: " + a);
            Console.WriteLine("Текущая длина строки " + a.Length);
            Console.WriteLine("Объем буфера " + a.Capacity);
            Console.WriteLine("Максимальный объем буфера " + a.MaxCapacity);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            #region символы
            //try
            //{
            //    char b = 'B', c = '\x64', d = '\uffff';
            //    Console.WriteLine("{0}, {1}, {2}", b, c, d);
            //    Console.WriteLine("{0}, {1}, {2}", char.ToLower(b), char.ToUpper(c), char.GetNumericValue(d));
            //    char a;
            //    do  // цикл выполняется, пока не ввели символ e
            //    {
            //        Console.WriteLine("Введите символ: ");
            //        a = char.Parse(Console.ReadLine());
            //        Console.WriteLine("Введен символ {0}, его код  {1}, его категория {2}", a, (int)a, char.GetUnicodeCategory(a));
            //        if (char.IsLetter(a)) Console.WriteLine("Буква");
            //        if (char.IsUpper(a)) Console.WriteLine("Верхний регистр");
            //        if (char.IsLower(a)) Console.WriteLine("Нижний регистр");
            //        if (char.IsControl(a)) Console.WriteLine("Управляющий символ");
            //        if (char.IsNumber(a)) Console.WriteLine("Число");
            //        if (char.IsPunctuation(a)) Console.WriteLine("Разделитель");
            //    } while (a != 'e');
            //}
            //catch
            //{
            //    Console.WriteLine("Возникло исключение");
            //}
            #endregion

            #region массив символов
            //char[] a = { 'm', 'a', 'Х', 'i', 'M', 'u', 'S', '!', '!', '!' };
            //char[] b = "кол около колокола".ToCharArray(); // преобразование строки в массив символов
            //PrintArray("Исходный массив а:", a);
            //for (int x = 0; x < a.Length; x++)
            //    if (char.IsLower(a[x])) a[x] = char.ToUpper(a[x]);
            //PrintArray("Измененный массив а:", a);
            //PrintArray("Исходный массив b:", b);
            //Array.Reverse(b);
            //PrintArray("Измененный массив b:", b);
            #endregion

            #region строки
            //string str1 = "Первая строка";
            //string str2 = string.Copy(str1);
            //string str3 = "Вторая строка";
            //string str4 = "ВТОРАЯ строка";
            //string strUp, strLow;
            //int result, idx;
            //Console.WriteLine("str1: " + str1);
            //Console.WriteLine("Длина строки str1: " + str1.Length);
            //// создаем прописную и строчную версии строки str1.
            //strLow = str1.ToLower();
            //strUp = str1.ToUpper();
            //Console.WriteLine("Строчная версия строки str1: " + strLow);
            //Console.WriteLine("Прописная версия строки str1: " + strUp);
            //Console.WriteLine();
            //// сравниваем строки
            //result = str1.CompareTo(str3);
            //if (result == 0) Console.WriteLine("str1 и str3 равны.");
            //else if (result < 0) Console.WriteLine("str1 меньше, чем str3");
            //else Console.WriteLine("str1 больше, чем str3");
            //Console.WriteLine();
            //// сравниваем строки без учета регистра
            //result = String.Compare(str3, str4, true);
            //if (result == 0) Console.WriteLine("str3 и str4 равны без учета регистра.");
            //else Console.WriteLine("str3 и str4 не равны без учета регистра.");
            //Console.WriteLine();
            //// сравниваем части строк
            //result = String.Compare(str1, 4, str2, 4, 2);
            //if (result == 0) Console.WriteLine("часть str1 и str2 равны");
            //else Console.WriteLine("часть str1 и str2 не равны");
            //Console.WriteLine();
            //// поиск строк
            //idx = str2.IndexOf("строка");
            //Console.WriteLine("Индекс первого вхождения подстроки строки: " + idx);
            //idx = str2.LastIndexOf("о");
            //Console.WriteLine("Индекс последнего вхождения символа о: " + idx);
            //// конкатенация
            //string str = String.Concat(str1, str2, str3, str4);
            //Console.WriteLine(str);
            //// удаление подстроки
            //str = str.Remove(0, str1.Length);
            //Console.WriteLine(str);
            //// замена подстроки "строка" на пустую подстроку
            //str = str.Replace("строка", "");
            //Console.WriteLine(str);
            #endregion

            #region разделения строки на элементы Split и слияние массива строк в единую строку Join 
            //string poems = "белеет парус одинокий в тумане моря голубом";
            //char[] div = { ' ' }; // создаем массив разделителей
            //// разбиваем строку на части,
            //string[] parts = poems.Split(div);
            //Console.WriteLine("Результат разбиения строки на части: ");
            //for (int i = 0; i < parts.Length; i++)
            //    Console.WriteLine(parts[i]);
            //// собираем эти части в одну строку, в качестве разделителя используем символ |
            //string str = String.Join("|", parts);
            //Console.WriteLine("Результат сборки: ");
            //Console.WriteLine(str);
            #endregion

            #region Compare и CompareTo
            //string s1 = "Hello!";
            //string s2 = "Hello!";
            //// сравнение с использованием статического метода
            //Console.WriteLine(String.Compare(s1, s2));
            //// сравнение с использованием нестатического метода
            //Console.WriteLine(s1.CompareTo(s2));
            //Console.WriteLine(s1 == s2);
            #endregion

            #region StringBuilder
            //try
            //{
            //    StringBuilder str = new StringBuilder("Площадь");
            //    PrintString(str);
            //    str.Append(" треугольника равна");
            //    PrintString(str);
            //    str.AppendFormat(" {0:f2} см ", 123.456);
            //    PrintString(str);
            //    str.Insert(8, "данного ");
            //    PrintString(str);
            //    str.Remove(7, 21);
            //    PrintString(str);
            //    str.Replace("а", "о");
            //    PrintString(str);
            //    Console.WriteLine("Введите первую строку для сравнения:");
            //    StringBuilder str1 = new StringBuilder(Console.ReadLine());
            //    Console.WriteLine("Введите вторую строку для сравнения:");
            //    StringBuilder str2 = new StringBuilder(Console.ReadLine());
            //    Console.WriteLine("Строки равны: " + str1.Equals(str2));
            //}
            //catch
            //{
            //    Console.WriteLine("Возникло исключение");
            //}
            #endregion

            #region С изменяемой строкой можно работать не только как с объектом, но и как с массивом символов
            //StringBuilder a = new StringBuilder("2*3=3*2");
            //Console.WriteLine(a);
            //int k = 0;
            //for (int i = 0; i < a.Length; ++i)
            //    if (char.IsDigit(a[i]))
            //        k += int.Parse(a[i].ToString());
            //Console.WriteLine(k);
            #endregion

            #region Сравним производительность работы StringBuilder с неизменяемыми строками
            //int iIterations = 10000;
            //DateTime dt = DateTime.Now;
            //string str = String.Empty;
            //for (int i = 0; i < iIterations; i++)
            //    str += "abcdefghijklmnopqrstuvwxyz\r\n";
            //Console.WriteLine(DateTime.Now - dt);

            //DateTime dt2 = DateTime.Now;
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < iIterations; i++)
            //    sb.Append("abcdefghijklmnopqrstuvwxyz\r\n");
            //string str2 = sb.ToString();
            //Console.WriteLine(DateTime.Now - dt2);
            #endregion

            #region Регулярные выражения Regex
            //string data1 = "Петр, Андрей, Николай";
            //string data2 = "Петр, Андрей, Александр";
            //Regex regex = new Regex("Николай");     // Создание регулярного выражения
            //Console.WriteLine(regex.IsMatch(data1)); // True
            //Console.WriteLine(regex.IsMatch(data2)); // False

            Regex myReg = new Regex(@"[A-Za-z]+[\.A-Za-z0-9_-]*[A-Za-z0-9]+@[A-Za-z0-9]+\.[A-Za-z]{2,6}");
            Console.WriteLine(myReg.IsMatch("email@email.com"));// True
            Console.WriteLine(myReg.IsMatch("email@email"));// False
            Console.WriteLine(myReg.IsMatch("@email.com"));
            #endregion

            Console.ReadKey();

        }
    }
}
