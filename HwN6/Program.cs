using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глотов Андрей
// №6
//*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

namespace HwN6
{
    public class UsefulMethods
    {
        public static void Print(string msg, int x, int y)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        public static void Pause()
        {
            //Ожидания нажатия клавиши
            Console.ReadKey();
        }

        static void Main()
        {

        }
    }
}
