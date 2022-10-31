
namespace WindowsFormsApp2
{
    partial class EkzamenAdditional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkzamenAdditional));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDЭкзаменаторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОПреподавателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.экзаменаторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet();
            this.экзаменаторTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.ЭкзаменаторTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDтипЭкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеЭкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типЭкзаменаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_экзаменаTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Тип_экзаменаTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменаторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЭкзаменаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЭкзаменаторDataGridViewTextBoxColumn,
            this.фИОПреподавателяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.экзаменаторBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(311, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDЭкзаменаторDataGridViewTextBoxColumn
            // 
            this.iDЭкзаменаторDataGridViewTextBoxColumn.DataPropertyName = "ID_Экзаменатор";
            this.iDЭкзаменаторDataGridViewTextBoxColumn.HeaderText = "ID_Экзаменатор";
            this.iDЭкзаменаторDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDЭкзаменаторDataGridViewTextBoxColumn.Name = "iDЭкзаменаторDataGridViewTextBoxColumn";
            this.iDЭкзаменаторDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОПреподавателяDataGridViewTextBoxColumn
            // 
            this.фИОПреподавателяDataGridViewTextBoxColumn.DataPropertyName = "ФИО преподавателя";
            this.фИОПреподавателяDataGridViewTextBoxColumn.HeaderText = "ФИО преподавателя";
            this.фИОПреподавателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОПреподавателяDataGridViewTextBoxColumn.Name = "фИОПреподавателяDataGridViewTextBoxColumn";
            this.фИОПреподавателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // экзаменаторBindingSource
            // 
            this.экзаменаторBindingSource.DataMember = "Экзаменатор";
            this.экзаменаторBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet
            // 
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.DataSetName = "База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet";
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // экзаменаторTableAdapter
            // 
            this.экзаменаторTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDтипЭкзаменаDataGridViewTextBoxColumn,
            this.наименованиеЭкзаменаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.типЭкзаменаBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(312, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDтипЭкзаменаDataGridViewTextBoxColumn
            // 
            this.iDтипЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "ID_тип экзамена";
            this.iDтипЭкзаменаDataGridViewTextBoxColumn.HeaderText = "ID_тип экзамена";
            this.iDтипЭкзаменаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDтипЭкзаменаDataGridViewTextBoxColumn.Name = "iDтипЭкзаменаDataGridViewTextBoxColumn";
            this.iDтипЭкзаменаDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеЭкзаменаDataGridViewTextBoxColumn
            // 
            this.наименованиеЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "Наименование экзамена";
            this.наименованиеЭкзаменаDataGridViewTextBoxColumn.HeaderText = "Наименование экзамена";
            this.наименованиеЭкзаменаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеЭкзаменаDataGridViewTextBoxColumn.Name = "наименованиеЭкзаменаDataGridViewTextBoxColumn";
            this.наименованиеЭкзаменаDataGridViewTextBoxColumn.Width = 125;
            // 
            // типЭкзаменаBindingSource
            // 
            this.типЭкзаменаBindingSource.DataMember = "Тип экзамена";
            this.типЭкзаменаBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // тип_экзаменаTableAdapter
            // 
            this.тип_экзаменаTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 31);
            this.button5.TabIndex = 12;
            this.button5.Text = "Вернутся";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Заменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDeleteLastRows_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EkzamenAdditional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(441, 324);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EkzamenAdditional";
            this.Text = "Дополнительно";
            this.Load += new System.EventHandler(this.EkzamenAdditional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменаторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЭкзаменаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЭкзаменаторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПреподавателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDтипЭкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеЭкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
        public System.Windows.Forms.BindingSource экзаменаторBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.ЭкзаменаторTableAdapter экзаменаторTableAdapter;
        public System.Windows.Forms.BindingSource типЭкзаменаBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Тип_экзаменаTableAdapter тип_экзаменаTableAdapter;
    }
}