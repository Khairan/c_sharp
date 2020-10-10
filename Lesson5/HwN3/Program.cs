using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
//№3
//*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
//Например:
//badc являются перестановкой abcd.

namespace HwN3
{    

    class Program
    {
        public static bool StrCompare(string msg1, string msg2)
        {
            char[] charArray = msg1.ToCharArray();
            Array.Reverse(charArray);
            return (String.Join("", charArray) == msg2);
        }

        static void Main(string[] args)
        {
            string msg1 = "Война миров";
            string msg2 = "ворим анйоВ";
            Console.WriteLine(StrCompare(msg1, msg2));

            Console.ReadKey();

        }
    }
}
