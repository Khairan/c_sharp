using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//глотов Андрей
//Задание №2
//Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown

namespace HwN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1_ValueChanged(null, null); //для обработки 0 значения при открытии формы
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }               
    }
}
