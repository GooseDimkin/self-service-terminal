using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Login
{
    public partial class Order : Form
    {
        public static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\terminal2\Login\Login\Мережа ресторанів.mdb;";

        private OleDbConnection myConnection;

        public Order()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectionString);

            myConnection.Open();
        }

        void Checker()
        {
            if (checkBox1.Checked == false &&
            checkBox2.Checked == false &&
            checkBox3.Checked == false &&
            checkBox4.Checked == false &&
            checkBox5.Checked == false &&
            checkBox6.Checked == false &&
            checkBox7.Checked == false &&
            checkBox8.Checked == false &&
            checkBox9.Checked == false &&
            checkBox10.Checked == false &&
            checkBox11.Checked == false &&
            checkBox12.Checked == false &&
            checkBox13.Checked == false &&
            checkBox14.Checked == false &&
            checkBox15.Checked == false &&
            checkBox16.Checked == false &&
            checkBox17.Checked == false &&
            checkBox18.Checked == false &&
            checkBox19.Checked == false &&
            checkBox20.Checked == false &&
            checkBox21.Checked == false &&
            checkBox22.Checked == false &&
            checkBox23.Checked == false &&
            checkBox24.Checked == false &&
            checkBox25.Checked == false &&
            checkBox26.Checked == false &&
            checkBox27.Checked == false &&
            checkBox28.Checked == false &&
            checkBox29.Checked == false &&
            checkBox30.Checked == false &&
            checkBox31.Checked == false &&
            checkBox32.Checked == false &&
            checkBox33.Checked == false &&
            checkBox34.Checked == false)
            {
                MessageBox.Show("Спочатку оберіть товар і його кількість.", "Зверніть увагу!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            int value = 0;
            int all = 0;

            textBox4.Text = "";

            Checker();

            if (checkBox1.Checked == true && comboBox1.Text == "" ||
                checkBox2.Checked == true && comboBox2.Text == "" ||
                checkBox3.Checked == true && comboBox3.Text == "" ||
                checkBox4.Checked == true && comboBox4.Text == "" ||
                checkBox5.Checked == true && comboBox5.Text == "" ||
                checkBox6.Checked == true && comboBox6.Text == "" ||
                checkBox7.Checked == true && comboBox7.Text == "" ||
                checkBox8.Checked == true && comboBox8.Text == "" ||
                checkBox9.Checked == true && comboBox9.Text == "" ||
                checkBox10.Checked == true && comboBox10.Text == "" ||
                checkBox11.Checked == true && comboBox11.Text == "" ||
                checkBox12.Checked == true && comboBox12.Text == "" ||
                checkBox13.Checked == true && comboBox13.Text == "" ||
                checkBox14.Checked == true && comboBox14.Text == "" ||
                checkBox15.Checked == true && comboBox15.Text == "" ||
                checkBox16.Checked == true && comboBox16.Text == "" ||
                checkBox17.Checked == true && comboBox17.Text == "" ||
                checkBox18.Checked == true && comboBox18.Text == "" ||
                checkBox19.Checked == true && comboBox19.Text == "" ||
                checkBox20.Checked == true && comboBox20.Text == "" ||
                checkBox21.Checked == true && comboBox21.Text == "" ||
                checkBox22.Checked == true && comboBox22.Text == "" ||
                checkBox23.Checked == true && comboBox23.Text == "" ||
                checkBox24.Checked == true && comboBox24.Text == "" ||
                checkBox25.Checked == true && comboBox25.Text == "" ||
                checkBox26.Checked == true && comboBox26.Text == "" ||
                checkBox27.Checked == true && comboBox27.Text == "" ||
                checkBox28.Checked == true && comboBox28.Text == "" ||
                checkBox29.Checked == true && comboBox29.Text == "" ||
                checkBox30.Checked == true && comboBox30.Text == "" ||
                checkBox31.Checked == true && comboBox31.Text == "" ||
                checkBox32.Checked == true && comboBox32.Text == "" ||
                checkBox33.Checked == true && comboBox33.Text == "" ||
                checkBox34.Checked == true && comboBox34.Text == "")
            {
                MessageBox.Show("Оберіть кількість.", "Зверніть увагу!");
            }
            else
            {

                void ShowCost(string ss, int num)
                {
                    s = ss;
                    value = Convert.ToInt32(s);

                    string query1 = "SELECT Ціна * " + value + " FROM Склад WHERE Номер_продукта = " + num;

                    OleDbCommand command1 = new OleDbCommand(query1, myConnection);

                    textBox4.Text = command1.ExecuteScalar().ToString();

                    all += Convert.ToInt32(textBox4.Text);

                    textBox4.Text = Convert.ToString(all);
                }

                void CheckBoxesForCost(CheckBox chb, ComboBox cb, int num)
                {
                    if (chb.Checked == true)
                        ShowCost(cb.Text, num);
                }

                CheckBoxesForCost(checkBox1, comboBox1, 1);
                CheckBoxesForCost(checkBox2, comboBox2, 2);
                CheckBoxesForCost(checkBox3, comboBox3, 3);
                CheckBoxesForCost(checkBox4, comboBox4, 4);
                CheckBoxesForCost(checkBox5, comboBox5, 5);
                CheckBoxesForCost(checkBox6, comboBox6, 6);
                CheckBoxesForCost(checkBox7, comboBox7, 7);
                CheckBoxesForCost(checkBox8, comboBox8, 8);
                CheckBoxesForCost(checkBox9, comboBox9, 9);
                CheckBoxesForCost(checkBox10, comboBox10, 10);
                CheckBoxesForCost(checkBox11, comboBox11, 11);
                CheckBoxesForCost(checkBox12, comboBox12, 12);
                CheckBoxesForCost(checkBox13, comboBox13, 13);
                CheckBoxesForCost(checkBox14, comboBox14, 14);
                CheckBoxesForCost(checkBox15, comboBox15, 15);
                CheckBoxesForCost(checkBox16, comboBox16, 16);
                CheckBoxesForCost(checkBox17, comboBox17, 17);
                CheckBoxesForCost(checkBox18, comboBox18, 18);
                CheckBoxesForCost(checkBox19, comboBox19, 19);
                CheckBoxesForCost(checkBox20, comboBox20, 20);
                CheckBoxesForCost(checkBox21, comboBox21, 21);
                CheckBoxesForCost(checkBox22, comboBox22, 22);
                CheckBoxesForCost(checkBox23, comboBox23, 23);
                CheckBoxesForCost(checkBox24, comboBox24, 24);
                CheckBoxesForCost(checkBox25, comboBox25, 25);
                CheckBoxesForCost(checkBox26, comboBox26, 26);
                CheckBoxesForCost(checkBox27, comboBox27, 27);
                CheckBoxesForCost(checkBox28, comboBox28, 28);
                CheckBoxesForCost(checkBox29, comboBox29, 29);
                CheckBoxesForCost(checkBox30, comboBox30, 30);
                CheckBoxesForCost(checkBox31, comboBox31, 31);
                CheckBoxesForCost(checkBox32, comboBox32, 32);
                CheckBoxesForCost(checkBox33, comboBox33, 33);
                CheckBoxesForCost(checkBox34, comboBox34, 34);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
            comboBox14.SelectedIndex = -1;
            comboBox15.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;
            comboBox18.SelectedIndex = -1;
            comboBox19.SelectedIndex = -1;
            comboBox20.SelectedIndex = -1;
            comboBox21.SelectedIndex = -1;
            comboBox22.SelectedIndex = -1;
            comboBox23.SelectedIndex = -1;
            comboBox24.SelectedIndex = -1;
            comboBox25.SelectedIndex = -1;
            comboBox26.SelectedIndex = -1;
            comboBox27.SelectedIndex = -1;
            comboBox28.SelectedIndex = -1;
            comboBox29.SelectedIndex = -1;
            comboBox30.SelectedIndex = -1;
            comboBox31.SelectedIndex = -1;
            comboBox32.SelectedIndex = -1;
            comboBox33.SelectedIndex = -1;
            comboBox34.SelectedIndex = -1;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;

            textBox4.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void CheckIfChecked(CheckBox chb, ComboBox cb)
        {
            if (chb.Checked == true)
                cb.Enabled = true;
            else if (chb.Checked == false)
            {
                cb.SelectedIndex = -1;
                cb.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox1, comboBox1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox2, comboBox2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox3, comboBox3);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox4, comboBox4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox5, comboBox5);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox6, comboBox6);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox7, comboBox7);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox8, comboBox8);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox9, comboBox9);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox10, comboBox10);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox11, comboBox11);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox12, comboBox12);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox13, comboBox13);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox14, comboBox14);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox15, comboBox15);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox16, comboBox16);
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox17, comboBox17);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox18, comboBox18);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox19, comboBox19);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox20, comboBox20);
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox21, comboBox21);
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox22, comboBox22);
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox23, comboBox23);
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox24, comboBox24);
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox25, comboBox25);
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox26, comboBox26);
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox27, comboBox27);
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox28, comboBox28);
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox29, comboBox29);
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox30, comboBox30);
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox31, comboBox31);
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox32, comboBox32);
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox33, comboBox33);
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfChecked(checkBox34, comboBox34);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Checker();

            if (checkBox1.Checked == true && comboBox1.Text == "" ||
            checkBox2.Checked == true && comboBox2.Text == "" ||
            checkBox3.Checked == true && comboBox3.Text == "" ||
            checkBox4.Checked == true && comboBox4.Text == "" ||
            checkBox5.Checked == true && comboBox5.Text == "" ||
            checkBox6.Checked == true && comboBox6.Text == "" ||
            checkBox7.Checked == true && comboBox7.Text == "" ||
            checkBox8.Checked == true && comboBox8.Text == "" ||
            checkBox9.Checked == true && comboBox9.Text == "" ||
            checkBox10.Checked == true && comboBox10.Text == "" ||
            checkBox11.Checked == true && comboBox11.Text == "" ||
            checkBox12.Checked == true && comboBox12.Text == "" ||
            checkBox13.Checked == true && comboBox13.Text == "" ||
            checkBox14.Checked == true && comboBox14.Text == "" ||
            checkBox15.Checked == true && comboBox15.Text == "" ||
            checkBox16.Checked == true && comboBox16.Text == "" ||
            checkBox17.Checked == true && comboBox17.Text == "" ||
            checkBox18.Checked == true && comboBox18.Text == "" ||
            checkBox19.Checked == true && comboBox19.Text == "" ||
            checkBox20.Checked == true && comboBox20.Text == "" ||
            checkBox21.Checked == true && comboBox21.Text == "" ||
            checkBox22.Checked == true && comboBox22.Text == "" ||
            checkBox23.Checked == true && comboBox23.Text == "" ||
            checkBox24.Checked == true && comboBox24.Text == "" ||
            checkBox25.Checked == true && comboBox25.Text == "" ||
            checkBox26.Checked == true && comboBox26.Text == "" ||
            checkBox27.Checked == true && comboBox27.Text == "" ||
            checkBox28.Checked == true && comboBox28.Text == "" ||
            checkBox29.Checked == true && comboBox29.Text == "" ||
            checkBox30.Checked == true && comboBox30.Text == "" ||
            checkBox31.Checked == true && comboBox31.Text == "" ||
            checkBox32.Checked == true && comboBox32.Text == "" ||
            checkBox33.Checked == true && comboBox33.Text == "" ||
            checkBox34.Checked == true && comboBox34.Text == "")
            {
                MessageBox.Show("Оберіть кількість.", "Зверніть увагу!");
            }

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введіть інформацію в поля!", "Зверніть увагу!");
            }
            else
            {
                string path = @"D:\Order.txt";
                using (System.IO.StreamWriter wt = new System.IO.StreamWriter(path, true))
                {
                    wt.Write("------------------------------------" + Environment.NewLine);
                    wt.Write("ПІБ: " + textBox1.Text + Environment.NewLine);
                    wt.Write("Контактний телефон: " + textBox2.Text + Environment.NewLine);
                    wt.Write("Замовлення: \n" + Environment.NewLine);
                    if (checkBox1.Checked)
                    {
                        wt.Write(checkBox1.Text + "; Кількість: " + comboBox1.Text + Environment.NewLine);
                        wt.Write("------------------------------------" + Environment.NewLine);
                    }
                    if (checkBox2.Checked)
                        wt.Write(checkBox2.Text + "; Кількість: " + comboBox2.Text + Environment.NewLine);
                    if (checkBox3.Checked)
                        wt.Write(checkBox3.Text + "; Кількість: " + comboBox3.Text + Environment.NewLine);
                    if (checkBox4.Checked)
                        wt.Write(checkBox4.Text + "; Кількість: " + comboBox4.Text + Environment.NewLine);
                    if (checkBox5.Checked)
                        wt.Write(checkBox5.Text + "; Кількість: " + comboBox5.Text + Environment.NewLine);
                    if (checkBox6.Checked)
                        wt.Write(checkBox6.Text + "; Кількість: " + comboBox6.Text + Environment.NewLine);
                    if (checkBox7.Checked)
                        wt.Write(checkBox7.Text + "; Кількість: " + comboBox7.Text + Environment.NewLine);
                    if (checkBox8.Checked)
                        wt.Write(checkBox8.Text + "; Кількість: " + comboBox8.Text + Environment.NewLine);
                    if (checkBox9.Checked)
                        wt.Write(checkBox9.Text + "; Кількість: " + comboBox9.Text + Environment.NewLine);
                    if (checkBox10.Checked)
                        wt.Write(checkBox10.Text + "; Кількість: " + comboBox10.Text + Environment.NewLine);
                    if (checkBox11.Checked)
                        wt.Write(checkBox11.Text + "; Кількість: " + comboBox11.Text + Environment.NewLine);
                    if (checkBox12.Checked)
                        wt.Write(checkBox12.Text + "; Кількість: " + comboBox12.Text + Environment.NewLine);
                    if (checkBox13.Checked)
                        wt.Write(checkBox13.Text + "; Кількість: " + comboBox13.Text + Environment.NewLine);
                    if (checkBox14.Checked)
                        wt.Write(checkBox14.Text + "; Кількість: " + comboBox14.Text + Environment.NewLine);
                    if (checkBox15.Checked)
                        wt.Write(checkBox15.Text + "; Кількість: " + comboBox15.Text + Environment.NewLine);
                    if (checkBox16.Checked)
                        wt.Write(checkBox16.Text + "; Кількість: " + comboBox16.Text + Environment.NewLine);
                    if (checkBox17.Checked)
                        wt.Write(checkBox17.Text + "; Кількість: " + comboBox17.Text + Environment.NewLine);
                    if (checkBox18.Checked)
                        wt.Write(checkBox18.Text + "; Кількість: " + comboBox18.Text + Environment.NewLine);
                    if (checkBox19.Checked)
                        wt.Write(checkBox19.Text + "; Кількість: " + comboBox19.Text + Environment.NewLine);
                    if (checkBox20.Checked)
                        wt.Write(checkBox20.Text + "; Кількість: " + comboBox20.Text + Environment.NewLine);
                    if (checkBox21.Checked)
                        wt.Write(checkBox21.Text + "; Кількість: " + comboBox21.Text + Environment.NewLine);
                    if (checkBox22.Checked)
                        wt.Write(checkBox22.Text + "; Кількість: " + comboBox22.Text + Environment.NewLine);
                    if (checkBox23.Checked)
                        wt.Write(checkBox23.Text + "; Кількість: " + comboBox23.Text + Environment.NewLine);
                    if (checkBox24.Checked)
                        wt.Write(checkBox24.Text + "; Кількість: " + comboBox24.Text + Environment.NewLine);
                    if (checkBox25.Checked)
                        wt.Write(checkBox25.Text + "; Кількість: " + comboBox25.Text + Environment.NewLine);
                    if (checkBox26.Checked)
                        wt.Write(checkBox26.Text + "; Кількість: " + comboBox26.Text + Environment.NewLine);
                    if (checkBox27.Checked)
                        wt.Write(checkBox27.Text + "; Кількість: " + comboBox27.Text + Environment.NewLine);
                    if (checkBox28.Checked)
                        wt.Write(checkBox28.Text + "; Кількість: " + comboBox28.Text + Environment.NewLine);
                    if (checkBox29.Checked)
                        wt.Write(checkBox29.Text + "; Кількість: " + comboBox29.Text + Environment.NewLine);
                    if (checkBox30.Checked)
                        wt.Write(checkBox30.Text + "; Кількість: " + comboBox30.Text + Environment.NewLine);
                    if (checkBox31.Checked)
                        wt.Write(checkBox31.Text + "; Кількість: " + comboBox31.Text + Environment.NewLine);
                    if (checkBox32.Checked)
                        wt.Write(checkBox32.Text + "; Кількість: " + comboBox32.Text + Environment.NewLine);
                    if (checkBox33.Checked)
                        wt.Write(checkBox33.Text + "; Кількість: " + comboBox33.Text + Environment.NewLine);
                    if (checkBox34.Checked)
                        wt.Write(checkBox34.Text + "; Кількість: " + comboBox34.Text + Environment.NewLine);
                    wt.Write("------------------------------------" + Environment.NewLine);

                    MessageBox.Show("Замовлення зроблено!\nочикуйте його найближчим часом!", "Зверніть увагу!");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Chair ch = new Chair();
            ch.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();

            this.Hide();
        }
    }
}
