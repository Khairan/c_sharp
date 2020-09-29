using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN1.Program;

/*Глотов Андрей
№4
Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.
*/

namespace HwN4
{
    class Program
    {
        static void Main(string[] args)
        {

            string login = "root", password = "Password";
            int tryCount = 3;

            Console.WriteLine("Введите логин и пароль для авторизации\n");

            while (tryCount > 0)
            {
                string userLogin = ParamRequest("login");
                string usrPassword = ParamRequest("password");

                if (userLogin == login && usrPassword == password)
                {
                    Console.WriteLine("\nВы успешно авторизованы!\nВозьмите с полки пирожок :)\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nНеверный логин или пароль\n");
                    tryCount--;
                }
            }

            if (tryCount == 0) Console.WriteLine("В доступе отказано!");

            Signature();


        }
    }
}