
namespace WindowsFormsApp2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDНаправлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПолDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDГруппаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDУчащийсяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.таблицаРаспределенияПоступающихBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet();
            this.таблица_распределения_поступающихTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Таблица_распределения_поступающихTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаРаспределенияПоступающихBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn,
            this.iDНаправлениеDataGridViewTextBoxColumn,
            this.iDПолDataGridViewTextBoxColumn,
            this.iDГруппаDataGridViewTextBoxColumn,
            this.iDУчащийсяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.таблицаРаспределенияПоступающихBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn
            // 
            this.iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn.DataPropertyName = "ID_Таблица распределения поступающих";
            this.iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn.HeaderText = "ID_Таблица распределения поступающих";
            this.iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn.Name = "iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn";
            this.iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDНаправлениеDataGridViewTextBoxColumn
            // 
            this.iDНаправлениеDataGridViewTextBoxColumn.DataPropertyName = "ID_Направление";
            this.iDНаправлениеDataGridViewTextBoxColumn.HeaderText = "ID_Направление";
            this.iDНаправлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDНаправлениеDataGridViewTextBoxColumn.Name = "iDНаправлениеDataGridViewTextBoxColumn";
            this.iDНаправлениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDПолDataGridViewTextBoxColumn
            // 
            this.iDПолDataGridViewTextBoxColumn.DataPropertyName = "ID_Пол";
            this.iDПолDataGridViewTextBoxColumn.HeaderText = "ID_Пол";
            this.iDПолDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПолDataGridViewTextBoxColumn.Name = "iDПолDataGridViewTextBoxColumn";
            this.iDПолDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDГруппаDataGridViewTextBoxColumn
            // 
            this.iDГруппаDataGridViewTextBoxColumn.DataPropertyName = "ID_Группа";
            this.iDГруппаDataGridViewTextBoxColumn.HeaderText = "ID_Группа";
            this.iDГруппаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDГруппаDataGridViewTextBoxColumn.Name = "iDГруппаDataGridViewTextBoxColumn";
            this.iDГруппаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDУчащийсяDataGridViewTextBoxColumn
            // 
            this.iDУчащийсяDataGridViewTextBoxColumn.DataPropertyName = "ID_Учащийся";
            this.iDУчащийсяDataGridViewTextBoxColumn.HeaderText = "ID_Учащийся";
            this.iDУчащийсяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDУчащийсяDataGridViewTextBoxColumn.Name = "iDУчащийсяDataGridViewTextBoxColumn";
            this.iDУчащийсяDataGridViewTextBoxColumn.Width = 125;
            // 
            // таблицаРаспределенияПоступающихBindingSource
            // 
            this.таблицаРаспределенияПоступающихBindingSource.DataMember = "Таблица распределения поступающих";
            this.таблицаРаспределенияПоступающихBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet
            // 
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.DataSetName = "База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet";
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица_распределения_поступающихTableAdapter
            // 
            this.таблица_распределения_поступающихTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(125, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonShowSearch_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(125, 457);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(238, 457);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Выход";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(238, 428);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Дополнительно";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 494);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Распределение поступающих";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаРаспределенияПоступающихBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
        private System.Windows.Forms.BindingSource таблицаРаспределенияПоступающихBindingSource;
        private База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Таблица_распределения_поступающихTableAdapter таблица_распределения_поступающихTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТаблицаРаспределенияПоступающихDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDНаправлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПолDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГруппаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУчащийсяDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
    }
}

