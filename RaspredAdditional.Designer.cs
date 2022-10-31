
namespace WindowsFormsApp2
{
    partial class RaspredAdditional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaspredAdditional));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDПолDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПолаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet();
            this.полTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.ПолTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDГруппаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеГруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группаTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.ГруппаTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDНаправлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеНаправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.направлениеTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.НаправлениеTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.направлениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПолDataGridViewTextBoxColumn,
            this.наименованиеПолаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.полBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(330, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDПолDataGridViewTextBoxColumn
            // 
            this.iDПолDataGridViewTextBoxColumn.DataPropertyName = "ID_Пол";
            this.iDПолDataGridViewTextBoxColumn.HeaderText = "ID_Пол";
            this.iDПолDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПолDataGridViewTextBoxColumn.Name = "iDПолDataGridViewTextBoxColumn";
            this.iDПолDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеПолаDataGridViewTextBoxColumn
            // 
            this.наименованиеПолаDataGridViewTextBoxColumn.DataPropertyName = "Наименование пола";
            this.наименованиеПолаDataGridViewTextBoxColumn.HeaderText = "Наименование пола";
            this.наименованиеПолаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеПолаDataGridViewTextBoxColumn.Name = "наименованиеПолаDataGridViewTextBoxColumn";
            this.наименованиеПолаDataGridViewTextBoxColumn.Width = 125;
            // 
            // полBindingSource
            // 
            this.полBindingSource.DataMember = "Пол";
            this.полBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet
            // 
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.DataSetName = "База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet";
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // полTableAdapter
            // 
            this.полTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDГруппаDataGridViewTextBoxColumn,
            this.наименованиеГруппыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.группаBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(330, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDГруппаDataGridViewTextBoxColumn
            // 
            this.iDГруппаDataGridViewTextBoxColumn.DataPropertyName = "ID_Группа";
            this.iDГруппаDataGridViewTextBoxColumn.HeaderText = "ID_Группа";
            this.iDГруппаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDГруппаDataGridViewTextBoxColumn.Name = "iDГруппаDataGridViewTextBoxColumn";
            this.iDГруппаDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеГруппыDataGridViewTextBoxColumn
            // 
            this.наименованиеГруппыDataGridViewTextBoxColumn.DataPropertyName = "Наименование группы";
            this.наименованиеГруппыDataGridViewTextBoxColumn.HeaderText = "Наименование группы";
            this.наименованиеГруппыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеГруппыDataGridViewTextBoxColumn.Name = "наименованиеГруппыDataGridViewTextBoxColumn";
            this.наименованиеГруппыDataGridViewTextBoxColumn.Width = 125;
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDНаправлениеDataGridViewTextBoxColumn,
            this.наименованиеНаправленияDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.направлениеBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 324);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(330, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // iDНаправлениеDataGridViewTextBoxColumn
            // 
            this.iDНаправлениеDataGridViewTextBoxColumn.DataPropertyName = "ID_Направление";
            this.iDНаправлениеDataGridViewTextBoxColumn.HeaderText = "ID_Направление";
            this.iDНаправлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDНаправлениеDataGridViewTextBoxColumn.Name = "iDНаправлениеDataGridViewTextBoxColumn";
            this.iDНаправлениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеНаправленияDataGridViewTextBoxColumn
            // 
            this.наименованиеНаправленияDataGridViewTextBoxColumn.DataPropertyName = "Наименование направления";
            this.наименованиеНаправленияDataGridViewTextBoxColumn.HeaderText = "Наименование направления";
            this.наименованиеНаправленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеНаправленияDataGridViewTextBoxColumn.Name = "наименованиеНаправленияDataGridViewTextBoxColumn";
            this.наименованиеНаправленияDataGridViewTextBoxColumn.Width = 125;
            // 
            // направлениеBindingSource
            // 
            this.направлениеBindingSource.DataMember = "Направление";
            this.направлениеBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // направлениеTableAdapter
            // 
            this.направлениеTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonShowSearch_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(404, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Заменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(404, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 31);
            this.button5.TabIndex = 7;
            this.button5.Text = "Вернутся";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // RaspredAdditional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 482);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RaspredAdditional";
            this.Text = "Дополнительно";
            this.Load += new System.EventHandler(this.RaspredAdditional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.направлениеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПолDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПолаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГруппаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеГруппыDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDНаправлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеНаправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
        public System.Windows.Forms.BindingSource полBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.ПолTableAdapter полTableAdapter;
        public System.Windows.Forms.BindingSource группаBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        public System.Windows.Forms.BindingSource направлениеBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.НаправлениеTableAdapter направлениеTableAdapter;
    }
}