
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(121, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.button1.Location = new System.Drawing.Point(513, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 441);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 402);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID_Программа";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название программы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Руководство оператора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Отчет";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 476);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID_Заказ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(297, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Андрей Полянский";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "1 Форма";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 520);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Перейти на форму 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private ИКС_ПЛАТDataSet иКС_ПЛАТDataSet;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
    }
}

