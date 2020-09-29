using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HwN1.Program;

//Глотов Андрей
// №2
//Написать метод подсчета количества цифр числа.

namespace HwN2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Подсчет количества цифр в числе");            
            string strNumber = ParamRequest("число");
            int counter = 0;
            
            foreach (char i in strNumber)
                {
                    if (i >= '0' && i <= '9') counter++;
                }
            
            Console.WriteLine($"Число {strNumber} содержит {counter} цифр");
            Signature();

        }
    }
}
