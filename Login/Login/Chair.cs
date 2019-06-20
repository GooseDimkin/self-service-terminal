using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Chair : Form
    {
        public Chair()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow s = new MainWindow();
            s.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = "";
            int value = 0;
            int quantity_of_chairs = 14;
            int row = 0;

            //

            OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=C:\terminal2\Login\Login\Мережа ресторанів.mdb");

            con2.Open();

            OleDbDataAdapter da2 = new OleDbDataAdapter("select * from Бронювання_столиків", con2);
            OleDbCommandBuilder cd2 = new OleDbCommandBuilder(da2);

            //

            OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=C:\terminal2\Login\Login\Мережа ресторанів.mdb");

            con1.Open();

            OleDbDataAdapter da1 = new OleDbDataAdapter("select * from Столики", con1);
            OleDbCommandBuilder cd1 = new OleDbCommandBuilder(da1);

            //

            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "Столики");

            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "Бронювання_столиків");

            if (comboBox1.Text == "" || textBox2.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Заповнiть усi поля для бронювання", "Звернiть увагу!");
            }

            for (int i = 1; i <= quantity_of_chairs; i++)
            {
                string str = i.ToString();

                if (comboBox1.Text == str)
                {
                    s = comboBox2.Text;

                    value = Convert.ToInt32(s);

                    if (value <= 0 || value >= 5)
                    {
                        MessageBox.Show("Максимальна кiлькiсть людей: 4.\nМiнiмальна: 1", "Звернiть увагу!");
                    }
                    else
                    {
                        ds1.Tables[0].Rows[row]["Статус"] = "Заброньовано";
                        ds2.Tables[0].Rows[row]["Кількість_чоловік"] = value;
                        ds2.Tables[0].Rows[row]["ПІБ"] = textBox2.Text;
                        ds2.Tables[0].Rows[row]["Дата_бронювання"] = dateTimePicker1.Text;

                        da1.Update(ds1, "Столики");
                        da2.Update(ds2, "Бронювання_столиків");
                        con1.Close();
                        con2.Close();

                        MessageBox.Show("Заброньовано!\n Звернiть увагу, що змiну вступлять в силу пiсля перезапуску додатку.", "Звернiть увагу!");
                    }
                }
                row++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
        @"Data Source=C:\terminal2\Login\Login\Мережа ресторанів.mdb");

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select Номер_столика, Статус from Столики where Статус=\"Вільний\"";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
