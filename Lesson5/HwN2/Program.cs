using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HwN1.Program;

//Глотов Андрей
//№2
//Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст,
// в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
// Здесь требуется использовать класс Dictionary.

namespace HwN2
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите текст сообщения\n");
            string msg = ParamRequest("текст сообщения");
            Console.WriteLine(Message.PrintWordsN(msg, 5));
            Console.WriteLine(Message.DeleteWords(msg, 's'));
            Console.WriteLine(Message.LongestWord(msg));
            Console.WriteLine(Message.NewString(msg));

            Console.ReadKey();
        }
    }
}
