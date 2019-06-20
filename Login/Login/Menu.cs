using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Menu : Form
    {
        public static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\terminal2\Login\Login\Мережа ресторанів.mdb;";

        private OleDbConnection myConnection;

        public Menu()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectionString);

            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow s = new MainWindow();
            s.Show();

            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        void ShowDetails(int num)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Images\Меню\" + num + ".png");

            string query1 = "SELECT Назва FROM Склад WHERE Номер_продукта = " + num;
            string query2 = "SELECT Опис FROM Склад WHERE Номер_продукта = " + num;
            string query3 = "SELECT Ціна FROM Склад WHERE Номер_продукта = " + num;

            string query4 = "SELECT Жири_Вiдсоток FROM Склад WHERE Номер_продукта = " + num;
            string query5 = "SELECT Вуглеводи_Вiдсоток FROM Склад WHERE Номер_продукта = " + num;
            string query6 = "SELECT Бiлки_Вiдсоток FROM Склад WHERE Номер_продукта = " + num;
            string query7 = "SELECT Сiль_Вiдсоток FROM Склад WHERE Номер_продукта = " + num;

            string query8 = "SELECT Жири_г FROM Склад WHERE Номер_продукта = " + num;
            string query9 = "SELECT Вуглеводи_г FROM Склад WHERE Номер_продукта = " + num;
            string query10 = "SELECT Бiлки_г FROM Склад WHERE Номер_продукта = " + num;
            string query11 = "SELECT Сiль_г FROM Склад WHERE Номер_продукта = " + num;

            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
            OleDbCommand command3 = new OleDbCommand(query3, myConnection);

            OleDbCommand command4 = new OleDbCommand(query4, myConnection);
            OleDbCommand command5 = new OleDbCommand(query5, myConnection);
            OleDbCommand command6 = new OleDbCommand(query6, myConnection);
            OleDbCommand command7 = new OleDbCommand(query7, myConnection);

            OleDbCommand command8 = new OleDbCommand(query8, myConnection);
            OleDbCommand command9 = new OleDbCommand(query9, myConnection);
            OleDbCommand command10 = new OleDbCommand(query10, myConnection);
            OleDbCommand command11 = new OleDbCommand(query11, myConnection);

            textBox1.Text = command1.ExecuteScalar().ToString();
            richTextBox1.Text = command2.ExecuteScalar().ToString();
            textBox2.Text = command3.ExecuteScalar().ToString();

            textBox1.Text = command1.ExecuteScalar().ToString();
            richTextBox1.Text = command2.ExecuteScalar().ToString();
            textBox2.Text = command3.ExecuteScalar().ToString();

            this.chart1.Series["Stats"].Points.Clear();

            this.chart1.Series["Stats"].Points.AddXY("Жири", command4.ExecuteScalar().ToString());
            this.chart1.Series["Stats"].Points.AddXY("Вуглеводи", command5.ExecuteScalar().ToString());
            this.chart1.Series["Stats"].Points.AddXY("Бiлки", command6.ExecuteScalar().ToString());
            this.chart1.Series["Stats"].Points.AddXY("Сiль", command7.ExecuteScalar().ToString());

            label1.Text = command4.ExecuteScalar().ToString() + "%";
            label5.Text = command5.ExecuteScalar().ToString() + "%";
            label6.Text = command6.ExecuteScalar().ToString() + "%";
            label7.Text = command7.ExecuteScalar().ToString() + "%";

            label8.Text = command8.ExecuteScalar().ToString() + "г";
            label10.Text = command9.ExecuteScalar().ToString() + "г";
            label11.Text = command10.ExecuteScalar().ToString() + "г";
            label12.Text = command11.ExecuteScalar().ToString() + "г";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(3);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(4);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(5);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(6);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(7);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(8);
        }

            private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(9);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(10);
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(11);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(12);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(13);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(14);
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(15);
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(16);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();

            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(17);
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(18);
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(19);
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(20);
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(21);
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(23);
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(22);
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(24);
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(25);
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(26);
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(27);
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(28);
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(29);
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(30);
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(31);
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(32);
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(33);
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            ShowDetails(34);
        }

        private void chart1_Click(object sender, EventArgs e)
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();

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
