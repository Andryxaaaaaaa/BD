
namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDРабочиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиедолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЗаказDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рабочиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иКС_ПЛАТDataSet = new WindowsFormsApp1.ИКС_ПЛАТDataSet();
            this.рабочиеTableAdapter = new WindowsFormsApp1.ИКС_ПЛАТDataSetTableAdapters.РабочиеTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рабочиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иКС_ПЛАТDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDРабочиеDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.возрастDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn,
            this.названиедолжностиDataGridViewTextBoxColumn,
            this.iDЗаказDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.рабочиеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDРабочиеDataGridViewTextBoxColumn
            // 
            this.iDРабочиеDataGridViewTextBoxColumn.DataPropertyName = "ID_Рабочие";
            this.iDРабочиеDataGridViewTextBoxColumn.HeaderText = "ID_Рабочие";
            this.iDРабочиеDataGridViewTextBoxColumn.Name = "iDРабочиеDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            // 
            // названиедолжностиDataGridViewTextBoxColumn
            // 
            this.названиедолжностиDataGridViewTextBoxColumn.DataPropertyName = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn.HeaderText = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn.Name = "названиедолжностиDataGridViewTextBoxColumn";
            // 
            // iDЗаказDataGridViewTextBoxColumn
            // 
            this.iDЗаказDataGridViewTextBoxColumn.DataPropertyName = "ID_Заказ";
            this.iDЗаказDataGridViewTextBoxColumn.HeaderText = "ID_Заказ";
            this.iDЗаказDataGridViewTextBoxColumn.Name = "iDЗаказDataGridViewTextBoxColumn";
            // 
            // рабочиеBindingSource
            // 
            this.рабочиеBindingSource.DataMember = "Рабочие";
            this.рабочиеBindingSource.DataSource = this.иКС_ПЛАТDataSet;
            // 
            // иКС_ПЛАТDataSet
            // 
            this.иКС_ПЛАТDataSet.DataSetName = "ИКС_ПЛАТDataSet";
            this.иКС_ПЛАТDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рабочиеTableAdapter
            // 
            this.рабочиеTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Перейти на форму 4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Перейти на форму 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "3 форма";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рабочиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иКС_ПЛАТDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public ИКС_ПЛАТDataSet иКС_ПЛАТDataSet;
        public System.Windows.Forms.BindingSource рабочиеBindingSource;
        public ИКС_ПЛАТDataSetTableAdapters.РабочиеTableAdapter рабочиеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРабочиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиедолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаказDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}