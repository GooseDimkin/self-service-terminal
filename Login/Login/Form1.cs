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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int counter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;

            if (textBox1.Text == "Admin" && textBox2.Text == "1337")
            {
                MainAdminForm m = new MainAdminForm();
                m.Show();

                this.Hide();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";

                MessageBox.Show("Невірний логін чи пароль","Зверніть увагу!");

                if (counter == 5)
                {
                    Error h = new Error();
                    h.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainWindow s = new MainWindow();
             s.Show();

             this.Hide();           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }
    }
}
