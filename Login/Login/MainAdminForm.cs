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
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Close();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainAdminForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мережа_ресторанівDataSet3.Бронювання_столиків". При необходимости она может быть перемещена или удалена.
            this.бронювання_столиківTableAdapter.Fill(this.мережа_ресторанівDataSet3.Бронювання_столиків);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мережа_ресторанівDataSet2.Столики". При необходимости она может быть перемещена или удалена.
            this.столикиTableAdapter.Fill(this.мережа_ресторанівDataSet2.Столики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мережа_ресторанівDataSet1.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.мережа_ресторанівDataSet1.Склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мережа_ресторанівDataSet.Співробітники". При необходимости она может быть перемещена или удалена.
            this.співробітникиTableAdapter.Fill(this.мережа_ресторанівDataSet.Співробітники);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
