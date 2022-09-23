using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /// /// Обязательная переменная конструктора.
        /// private System.ComponentModel.IContainer components = null;
        public Form1()
        {
            InitializeComponent();
            
        }

        DataTable table = new DataTable();
        int selectedRow;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иКС_ПЛАТDataSet.Рабочие". При необходимости она может быть перемещена или удалена.
            this.рабочиеTableAdapter.Fill(this.иКС_ПЛАТDataSet.Рабочие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иКС_ПЛАТDataSet.Программный_продукт". При необходимости она может быть перемещена или удалена.
            this.программный_продуктTableAdapter.Fill(this.иКС_ПЛАТDataSet.Программный_продукт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иКС_ПЛАТDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.иКС_ПЛАТDataSet.Заказ);

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
            newDataRow.Cells[0].Value = textBox1.Text;
            newDataRow.Cells[1].Value = textBox2.Text;
            newDataRow.Cells[2].Value = textBox3.Text;
            newDataRow.Cells[3].Value = textBox4.Text;
            newDataRow.Cells[3].Value = textBox5.Text;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[3].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            иКС_ПЛАТDataSet.Программный_продукт.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            dataGridView1.DataSource = иКС_ПЛАТDataSet.Программный_продукт;
        }

        // Кнопка «Редактировать»

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form2 fm2 = new Form2();
            fm2.Show();
            fm2.Owner = this;
            Hide();
            
        }
    }
}
