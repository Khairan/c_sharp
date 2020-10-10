using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    static class Message
    {

        /// <summary>
        /// Выводит только те слова сообщения, которые содержат не более n букв
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string PrintWordsN(string msg, int n)
        {
            string newmsg = string.Empty;
            string[] parts = msg.Split(' ');
            foreach (string part in parts)
            {
                if (part.Length == n) newmsg += $"{part} ";
            }
            return newmsg;
        }

        /// <summary>
        /// Удаляет из сообщения все слова, которые заканчиваются на заданный символ
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string DeleteWords(string msg, char endchar)
        {
            string[] parts = msg.Split(' ');
            foreach (string part in parts)
            {
                if (part.EndsWith(endchar.ToString())) msg.Replace(part, "");
                
            }            
            
            return msg;
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите текст сообщения\n");
            string msg = ParamRequest("текст сообщения");
            Console.WriteLine(Message.PrintWordsN(msg, 5));
            Console.WriteLine(Message.DeleteWords(msg, 's'));

            Console.ReadKey();
        }
    }
}
