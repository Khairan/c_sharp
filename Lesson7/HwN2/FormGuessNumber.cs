using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Глотов Андрей
//задание №2
//Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
//a) Для ввода данных от человека используется элемент TextBox;
//б) **Реализовать отдельную форму c TextBox для ввода числа.

namespace HwN2
{
    public partial class FormGuessNumber : Form
    {
        public int guessedNumber;

        public FormGuessNumber()
        {
            InitializeComponent();
            this.Text = "Угадай число";
            var rnd = new Random();
            guessedNumber = rnd.Next(1, 100);
        }

        private void userNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int number = int.Parse(userNumber.Text);
                if (number == guessedNumber) { MessageBox.Show("Поздравляю, вы отгадали!"); Close(); }
                else if (number > guessedNumber) MessageBox.Show("Слишком большое число");
                else MessageBox.Show("Слишком маленькое число");
            }
        }
               
    }
}
