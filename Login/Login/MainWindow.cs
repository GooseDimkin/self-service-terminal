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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Questions q = new Questions();
            q.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Info i = new Info();
            i.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Chair c = new Chair();
            c.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Chair c = new Chair();
            c.Show();

            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Info i = new Info();
            i.Show();

            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();

            this.Hide();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Info i = new Info();
            i.Show();

            this.Hide();
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            Chair ch = new Chair();
            ch.Show();

            this.Hide();
        }
    }
}
