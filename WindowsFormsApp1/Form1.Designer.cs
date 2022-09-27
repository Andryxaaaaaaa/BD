
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.иКС_ПЛАТDataSet = new WindowsFormsApp1.ИКС_ПЛАТDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new WindowsFormsApp1.ИКС_ПЛАТDataSetTableAdapters.ЗаказTableAdapter();
            this.программныйпродуктBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.программный_продуктTableAdapter = new WindowsFormsApp1.ИКС_ПЛАТDataSetTableAdapters.Программный_продуктTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDПрограммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиепрограммыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.руководствооператораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЗаказDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.рабочиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рабочиеTableAdapter = new WindowsFormsApp1.ИКС_ПЛАТDataSetTableAdapters.РабочиеTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.иКС_ПЛАТDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.программныйпродуктBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рабочиеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // иКС_ПЛАТDataSet
            // 
            this.иКС_ПЛАТDataSet.DataSetName = "ИКС_ПЛАТDataSet";
            this.иКС_ПЛАТDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.иКС_ПЛАТDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // программныйпродуктBindingSource
            // 
            this.программныйпродуктBindingSource.DataMember = "Программный_продукт";
            this.программныйпродуктBindingSource.DataSource = this.иКС_ПЛАТDataSet;
            // 
            // программный_продуктTableAdapter
            // 
            this.программный_продуктTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПрограммаDataGridViewTextBoxColumn,
            this.названиепрограммыDataGridViewTextBoxColumn,
            this.руководствооператораDataGridViewTextBoxColumn,
            this.отчетDataGridViewTextBoxColumn,
            this.iDЗаказDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.программныйпродуктBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(121, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDПрограммаDataGridViewTextBoxColumn
            // 
            this.iDПрограммаDataGridViewTextBoxColumn.DataPropertyName = "ID_Программа";
            this.iDПрограммаDataGridViewTextBoxColumn.HeaderText = "ID_Программа";
            this.iDПрограммаDataGridViewTextBoxColumn.Name = "iDПрограммаDataGridViewTextBoxColumn";
            // 
            // названиепрограммыDataGridViewTextBoxColumn
            // 
            this.названиепрограммыDataGridViewTextBoxColumn.DataPropertyName = "Название_программы";
            this.названиепрограммыDataGridViewTextBoxColumn.HeaderText = "Название_программы";
            this.названиепрограммыDataGridViewTextBoxColumn.Name = "названиепрограммыDataGridViewTextBoxColumn";
            // 
            // руководствооператораDataGridViewTextBoxColumn
            // 
            this.руководствооператораDataGridViewTextBoxColumn.DataPropertyName = "Руководство_оператора";
            this.руководствооператораDataGridViewTextBoxColumn.HeaderText = "Руководство_оператора";
            this.руководствооператораDataGridViewTextBoxColumn.Name = "руководствооператораDataGridViewTextBoxColumn";
            // 
            // отчетDataGridViewTextBoxColumn
            // 
            this.отчетDataGridViewTextBoxColumn.DataPropertyName = "Отчет";
            this.отчетDataGridViewTextBoxColumn.HeaderText = "Отчет";
            this.отчетDataGridViewTextBoxColumn.Name = "отчетDataGridViewTextBoxColumn";
            // 
            // iDЗаказDataGridViewTextBoxColumn
            // 
            this.iDЗаказDataGridViewTextBoxColumn.DataPropertyName = "ID_Заказ";
            this.iDЗаказDataGridViewTextBoxColumn.HeaderText = "ID_Заказ";
            this.iDЗаказDataGridViewTextBoxColumn.Name = "iDЗаказDataGridViewTextBoxColumn";
            // 
            // заказBindingSource1
            // 
            this.заказBindingSource1.DataMember = "Заказ";
            this.заказBindingSource1.DataSource = this.иКС_ПЛАТDataSet;
            // 
            // рабочиеBindingSource
            // 
            this.рабочиеBindingSource.DataMember = "Рабочие";
            this.рабочиеBindingSource.DataSource = this.иКС_ПЛАТDataSet;
            // 
            // рабочиеTableAdapter
            // 
            this.рабочиеTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 416);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 450);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(228, 485);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 20);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(98, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID_Программа";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(47, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название программы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(30, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Руководство оператора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(162, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Отчет";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 45);
            this.button4.TabIndex = 16;
            this.button4.Text = "Добавить запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(142, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID_Заказ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(228, 522);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(219, 20);
            this.textBox5.TabIndex = 24;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(156, 303);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(406, 20);
            this.textBox6.TabIndex = 25;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(156, 339);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(406, 20);
            this.textBox7.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(95, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Поиск";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(80, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Фильтр";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(568, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 30);
            this.button5.TabIndex = 29;
            this.button5.Text = "Найти";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(568, 335);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 30);
            this.button6.TabIndex = 30;
            this.button6.Text = "Отфильтровать";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Основная программа";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.иКС_ПЛАТDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.программныйпродуктBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рабочиеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ИКС_ПЛАТDataSet иКС_ПЛАТDataSet;
        public System.Windows.Forms.BindingSource заказBindingSource;
        public ИКС_ПЛАТDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        public System.Windows.Forms.BindingSource программныйпродуктBindingSource;
        public ИКС_ПЛАТDataSetTableAdapters.Программный_продуктTableAdapter программный_продуктTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource заказBindingSource1;
        public System.Windows.Forms.BindingSource рабочиеBindingSource;
        public ИКС_ПЛАТDataSetTableAdapters.РабочиеTableAdapter рабочиеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПрограммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиепрограммыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn руководствооператораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаказDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

