using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN6.UsefulMethods;

//Глотов Андрей
// №5
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) *Сделать задание, только вывод организовать в центре экрана.
//в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y)
// №6
//*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

namespace HwN5_N6
{           
    class Program
    {        
        static void Main()
        {
            string msg = "Глотов Андрей г. Санкт-Петербург";
            int centerX = (Console.WindowWidth / 2) - (msg.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            
            Print("Глотов Андрей г. Санкт-Петербург", centerX, centerY);
            Pause();
            
        }
    }
}
