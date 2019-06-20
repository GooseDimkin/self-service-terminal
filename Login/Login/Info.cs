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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registr reg = new Registr();
            reg.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Questions q = new Questions();
            q.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Chair ch = new Chair();
            ch.Show();

            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
