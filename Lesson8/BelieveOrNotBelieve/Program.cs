using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

//глотов Андрей
//Задание №3
//а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок
// (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
//г)*Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).

namespace BelieveOrNotBelieve
{
    // Класс для вопроса    
    [Serializable]
    public class Question
    {
        public string text; // Текст вопроса
        public bool trueFalse;  // Правда или нет
                                // Здесь мы нарушаем правила инкапсуляции и эти поля нужно было бы реализовать через открытые свойства, но для упрощения примера оставим так
                                // Вам же предлагается сделать поля закрытыми и реализовать открытые свойства Text и TrueFalse

        //public string Text { get { return text; } set { text = value; } }
        //public bool TrueFalse { get { return trueFalse; } set { trueFalse = value; } }

        // Для сериализации должен быть пустой конструктор.
        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }
    
    // Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
    class TrueFalse
    {
        string fileName;
        List<Question> list;

        public string FileName
        {
            set { fileName = value; }
        }

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (list != null && index <= list.Count && index >= 0) list.RemoveAt(index-1);
        }

        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get { return list[index]; }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public bool Load()
        {
            bool fileLoaded;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {
                list = (List<Question>)xmlFormat.Deserialize(fStream);
                fileLoaded = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат файла!");
                fileLoaded = false;
            }
            fStream.Close();
            return fileLoaded;
        }

        public int Count
        {
            get { return list.Count; }
        }
    }


    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
