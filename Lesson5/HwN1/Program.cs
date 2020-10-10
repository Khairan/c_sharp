using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Глотов Андрей
//№1
//Создать программу, которая будет проверять корректность ввода логина.
//Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) **с использованием регулярных выражений.


namespace HwN1
{
    public class Program
    {
        /// <summary>
        /// Запрашиваем параметр и возвращаем ответ
        /// </summary>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public static string ParamRequest(string paramName)
        {
            Console.Write($"Введите {paramName}: ");
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Проверка логина\n");
            string userLogin = ParamRequest("login");
            bool f = true;

            //без использования регулярных выражений;
            if (userLogin.Length >= 2 && userLogin.Length <= 10 && !char.IsNumber(userLogin[0]))
            {
                foreach (char c in userLogin)
                    if (!char.IsLetterOrDigit(c))
                    {
                        f = false;
                        break;
                    }
            }
            else f = false;

            Console.WriteLine($"\n{(f ? "Ве" : "Неве")}рный формат логина");

            //с использованием регулярных выражений
            Regex myReg = new Regex(@"[A-Za-z]+[A-Za-z0-9]{1,9}");
            f = myReg.IsMatch(userLogin);
            
            Console.WriteLine($"\n{(f ? "Ве" : "Неве")}рный формат логина");

            Console.ReadKey();            

        }
    }
}
