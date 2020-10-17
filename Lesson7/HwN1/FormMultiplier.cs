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
//задание №1
//а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
//в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
//Вся логика игры должна быть реализована в классе с удвоителем.

namespace HwN1
{
    public partial class FormMultiplier : System.Windows.Forms.Form
    {
        public int guessnumber;

        public FormMultiplier()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
            commandNumber.Text = "0";
            guessNumber.Text = "Число 0";
                        
        }

        private void IncreaseCommandNumber()
        {
            commandNumber.Text = (int.Parse(commandNumber.Text) + 1).ToString();
            if (guessnumber == int.Parse(lblNumber.Text)) MessageBox.Show($"Вы достигли числа за {commandNumber.Text} ходов");
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            IncreaseCommandNumber();
        }      

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            IncreaseCommandNumber();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            IncreaseCommandNumber();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            commandNumber.Text = "0";
            var rnd = new Random();
            guessnumber = rnd.Next(1, 1000);
            MessageBox.Show($"Получите число {guessnumber} за минимальное количество ходов");
            guessNumber.Text = "Число " + guessnumber.ToString();
        }
    }
}
