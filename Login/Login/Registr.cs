using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Всі поля з позначкою \"*\" повинні бути заповнені!","Зверніть увагу!");
            } else
            {
                string path = @"D:\Ankets.txt";
                using (System.IO.StreamWriter wt = new System.IO.StreamWriter(path, true))
                {
                    wt.Write("------------------------------------" + Environment.NewLine);
                    wt.Write("Прізвище: " + textBox1.Text + Environment.NewLine);
                    wt.Write("Ім'я: " + textBox2.Text + Environment.NewLine);
                    wt.Write("По батькові: " + textBox3.Text + Environment.NewLine);
                    wt.Write("Контактний телефон: " + textBox4.Text + Environment.NewLine);
                    wt.Write("E-mail: " + textBox5.Text + Environment.NewLine);
                    wt.Write("Про себе: " + richTextBox1.Text + Environment.NewLine);
                    wt.Write("------------------------------------" + Environment.NewLine);
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                richTextBox1.Text = "";

                MessageBox.Show("Анкета выдправлена!\nМы зв'яжимося за вами найближчым часом!","Зверніть увагу!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();

            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Info i = new Info();
            i.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Chair ch = new Chair();
            ch.Show();

            this.Hide();
        }
    }
}
