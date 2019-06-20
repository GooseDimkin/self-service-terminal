using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class WriteQuestion : Form
    {
        public WriteQuestion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Всі поля з позначкою \"*\" повинні бути заповнені!","Зверніть увагу!");
            }
            else
            {
                string path = @"D:\Questions.txt";
                using (System.IO.StreamWriter wt = new System.IO.StreamWriter(path, true))
                {
                    wt.Write("------------------------------------" + Environment.NewLine);
                    wt.Write("Прізвище: " + textBox1.Text + Environment.NewLine);
                    wt.Write("Ім'я: " + textBox2.Text + Environment.NewLine);
                    wt.Write("По батькові: " + textBox3.Text + Environment.NewLine);
                    wt.Write("Контактний телефон: " + textBox4.Text + Environment.NewLine);
                    wt.Write("E-mail: " + textBox5.Text + Environment.NewLine);
                    wt.Write("Запитання: " + richTextBox1.Text + Environment.NewLine);
                    wt.Write("------------------------------------" + Environment.NewLine);
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                richTextBox1.Text = "";

                MessageBox.Show("Дякуємо за запитання!\nВи отримаєте відповідь від агента підтримки найближчым часом!","Зверніть увагу!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Questions s = new Questions();
            s.Show();

            this.Hide();
        }
    }
}
