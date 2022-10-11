using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm
    {
        /// /// Обязательная переменная конструктора.
        /// private System.ComponentModel.IContainer components = null;
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal600, Primary.Teal600, Primary.Teal600, Accent.Teal100, TextShade.WHITE);


        }

        DataTable table = new DataTable();
        int selectedRow;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "иКС_ПЛАТDataSet1.Программный_продукт". При необходимости она может быть перемещена или удалена.
            
            

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
            newDataRow.Cells[0].Value = materialTextBox3.Text;
            newDataRow.Cells[1].Value = materialTextBox4.Text;
            newDataRow.Cells[2].Value = materialTextBox5.Text;
            newDataRow.Cells[3].Value = materialTextBox6.Text;
            newDataRow.Cells[3].Value = materialTextBox7.Text;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            materialTextBox3.Text = row.Cells[0].Value.ToString();
            materialTextBox4.Text = row.Cells[1].Value.ToString();
            materialTextBox5.Text = row.Cells[2].Value.ToString();
            materialTextBox6.Text = row.Cells[3].Value.ToString();
            materialTextBox7.Text = row.Cells[3].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        // Кнопка «Редактировать»

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)// Переход на новую форму
        {
            
            Form2 fm2 = new Form2();
            fm2.Show();
            fm2.Owner = this;
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if
                        (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(materialTextBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }

                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            программныйпродуктBindingSource.Filter = "(ID_Программа = '" + materialTextBox2.Text + "')";
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            иКС_ПЛАТDataSet.Программный_продукт.Rows.Add(materialTextBox3.Text, materialTextBox4.Text, materialTextBox5.Text, materialTextBox6.Text, materialTextBox7.Text);
            dataGridView1.DataSource = иКС_ПЛАТDataSet.Программный_продукт;
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
            newDataRow.Cells[0].Value = materialTextBox3.Text;
            newDataRow.Cells[1].Value = materialTextBox4.Text;
            newDataRow.Cells[2].Value = materialTextBox5.Text;
            newDataRow.Cells[3].Value = materialTextBox6.Text;
            newDataRow.Cells[3].Value = materialTextBox7.Text;

        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            fm2.Owner = this;
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
    }
}
