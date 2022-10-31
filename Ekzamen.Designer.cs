
namespace WindowsFormsApp2
{
    partial class Ekzamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekzamen));
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet();
            this.типЭкзаменаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_экзаменаTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Тип_экзаменаTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.проведениеЭкзаменаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.проведение_экзаменаTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Проведение_экзаменаTableAdapter();
            this.iDУчащийсяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТипЭкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЭкзаменаторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЭкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеЭкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПроведениеЭкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЭкзаменаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проведениеЭкзаменаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet
            // 
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.DataSetName = "База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet";
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // проведениеЭкзаменаBindingSource
            // 
            this.проведениеЭкзаменаBindingSource.DataMember = "Проведение экзамена";
            this.проведениеЭкзаменаBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // проведение_экзаменаTableAdapter
            // 
            this.проведение_экзаменаTableAdapter.ClearBeforeFill = true;
            // 
            // iDУчащийсяDataGridViewTextBoxColumn
            // 
            this.iDУчащийсяDataGridViewTextBoxColumn.DataPropertyName = "ID_Учащийся";
            this.iDУчащийсяDataGridViewTextBoxColumn.HeaderText = "ID_Учащийся";
            this.iDУчащийсяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDУчащийсяDataGridViewTextBoxColumn.Name = "iDУчащийсяDataGridViewTextBoxColumn";
            this.iDУчащийсяDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDТипЭкзаменаDataGridViewTextBoxColumn
            // 
            this.iDТипЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "ID_Тип экзамена";
            this.iDТипЭкзаменаDataGridViewTextBoxColumn.HeaderText = "ID_Тип экзамена";
            this.iDТипЭкзаменаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDТипЭкзаменаDataGridViewTextBoxColumn.Name = "iDТипЭкзаменаDataGridViewTextBoxColumn";
            this.iDТипЭкзаменаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn
            // 
            this.iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn.DataPropertyName = "ID_Учёт музыкальных инструментов";
            this.iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn.HeaderText = "ID_Учёт музыкальных инструментов";
            this.iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn.Name = "iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn";
            this.iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDЭкзаменаторDataGridViewTextBoxColumn
            // 
            this.iDЭкзаменаторDataGridViewTextBoxColumn.DataPropertyName = "ID_Экзаменатор";
            this.iDЭкзаменаторDataGridViewTextBoxColumn.HeaderText = "ID_Экзаменатор";
            this.iDЭкзаменаторDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDЭкзаменаторDataGridViewTextBoxColumn.Name = "iDЭкзаменаторDataGridViewTextBoxColumn";
            this.iDЭкзаменаторDataGridViewTextBoxColumn.Width = 125;
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            this.оценкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЭкзаменаDataGridViewTextBoxColumn
            // 
            this.датаЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "Дата экзамена";
            this.датаЭкзаменаDataGridViewTextBoxColumn.HeaderText = "Дата экзамена";
            this.датаЭкзаменаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЭкзаменаDataGridViewTextBoxColumn.Name = "датаЭкзаменаDataGridViewTextBoxColumn";
            this.датаЭкзаменаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеЭкзаменаDataGridViewTextBoxColumn
            // 
            this.названиеЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "Название экзамена";
            this.названиеЭкзаменаDataGridViewTextBoxColumn.HeaderText = "Название экзамена";
            this.названиеЭкзаменаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеЭкзаменаDataGridViewTextBoxColumn.Name = "названиеЭкзаменаDataGridViewTextBoxColumn";
            this.названиеЭкзаменаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDПроведениеЭкзаменаDataGridViewTextBoxColumn
            // 
            this.iDПроведениеЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "ID_Проведение экзамена";
            this.iDПроведениеЭкзаменаDataGridViewTextBoxColumn.HeaderText = "ID_Проведение экзамена";
            this.iDПроведениеЭкзаменаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПроведениеЭкзаменаDataGridViewTextBoxColumn.Name = "iDПроведениеЭкзаменаDataGridViewTextBoxColumn";
            this.iDПроведениеЭкзаменаDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПроведениеЭкзаменаDataGridViewTextBoxColumn,
            this.названиеЭкзаменаDataGridViewTextBoxColumn,
            this.датаЭкзаменаDataGridViewTextBoxColumn,
            this.оценкаDataGridViewTextBoxColumn,
            this.iDЭкзаменаторDataGridViewTextBoxColumn,
            this.iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn,
            this.iDТипЭкзаменаDataGridViewTextBoxColumn,
            this.iDУчащийсяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.проведениеЭкзаменаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(133, 452);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Выход";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 452);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 423);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Сохранение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(254, 423);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Дополнительно";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Ekzamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 487);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ekzamen";
            this.Text = "Проведение экзаменации";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типЭкзаменаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проведениеЭкзаменаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроведениеЭкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеЭкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЭкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЭкзаменаторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУчётМузыкальныхИнструментовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТипЭкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУчащийсяDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
        public System.Windows.Forms.BindingSource типЭкзаменаBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Тип_экзаменаTableAdapter тип_экзаменаTableAdapter;
        public System.Windows.Forms.BindingSource проведениеЭкзаменаBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Проведение_экзаменаTableAdapter проведение_экзаменаTableAdapter;
        private System.Windows.Forms.Button button8;
    }
}