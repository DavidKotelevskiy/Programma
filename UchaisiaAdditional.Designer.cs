
namespace WindowsFormsApp2
{
    partial class UchaisiaAdditional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UchaisiaAdditional));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDМузыкальныйИнструментDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПроизводительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.музыкальныйИнструментBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet();
            this.музыкальный_инструментTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Музыкальный_инструментTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Учащийся = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учётМузыкальныхИнстурментовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учёт_музыкальных_инстурментовTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Учёт_музыкальных_инстурментовTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерМузыкальногоИнструментаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расшифровкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерМузыкальногоИнструментаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номер_музыкального_инструментаTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Номер_музыкального_инструментаTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.iDПроизводительDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПроизводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.производительTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.ПроизводительTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.музыкальныйИнструментBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётМузыкальныхИнстурментовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номерМузыкальногоИнструментаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производительBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМузыкальныйИнструментDataGridViewTextBoxColumn,
            this.наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn,
            this.iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn,
            this.iDПроизводительDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.музыкальныйИнструментBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDМузыкальныйИнструментDataGridViewTextBoxColumn
            // 
            this.iDМузыкальныйИнструментDataGridViewTextBoxColumn.DataPropertyName = "ID_Музыкальный инструмент";
            this.iDМузыкальныйИнструментDataGridViewTextBoxColumn.HeaderText = "ID_Музыкальный инструмент";
            this.iDМузыкальныйИнструментDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDМузыкальныйИнструментDataGridViewTextBoxColumn.Name = "iDМузыкальныйИнструментDataGridViewTextBoxColumn";
            this.iDМузыкальныйИнструментDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn
            // 
            this.наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn.DataPropertyName = "Наименование музыкального инструмента";
            this.наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn.HeaderText = "Наименование музыкального инструмента";
            this.наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn.Name = "наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn";
            this.наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn
            // 
            this.iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn.DataPropertyName = "ID_Номер музыкального инструмента";
            this.iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn.HeaderText = "ID_Номер музыкального инструмента";
            this.iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn.Name = "iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn";
            this.iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDПроизводительDataGridViewTextBoxColumn
            // 
            this.iDПроизводительDataGridViewTextBoxColumn.DataPropertyName = "ID_Производитель";
            this.iDПроизводительDataGridViewTextBoxColumn.HeaderText = "ID_Производитель";
            this.iDПроизводительDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПроизводительDataGridViewTextBoxColumn.Name = "iDПроизводительDataGridViewTextBoxColumn";
            this.iDПроизводительDataGridViewTextBoxColumn.Width = 125;
            // 
            // музыкальныйИнструментBindingSource
            // 
            this.музыкальныйИнструментBindingSource.DataMember = "Музыкальный инструмент";
            this.музыкальныйИнструментBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet
            // 
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.DataSetName = "База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet";
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // музыкальный_инструментTableAdapter
            // 
            this.музыкальный_инструментTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ID_Учащийся});
            this.dataGridView2.DataSource = this.учётМузыкальныхИнстурментовBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 476);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(562, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Музыкальный инструмент";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Музыкальный инструмент";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // ID_Учащийся
            // 
            this.ID_Учащийся.DataPropertyName = "ID_Учащийся";
            this.ID_Учащийся.HeaderText = "ID_Учащийся";
            this.ID_Учащийся.MinimumWidth = 6;
            this.ID_Учащийся.Name = "ID_Учащийся";
            this.ID_Учащийся.Width = 125;
            // 
            // учётМузыкальныхИнстурментовBindingSource
            // 
            this.учётМузыкальныхИнстурментовBindingSource.DataMember = "Учёт музыкальных инстурментов";
            this.учётМузыкальныхИнстурментовBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // учёт_музыкальных_инстурментовTableAdapter
            // 
            this.учёт_музыкальных_инстурментовTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1,
            this.номерМузыкальногоИнструментаDataGridViewTextBoxColumn,
            this.расшифровкаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.номерМузыкальногоИнструментаBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(13, 169);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(430, 150);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1
            // 
            this.iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1.DataPropertyName = "ID_номер музыкального инструмента";
            this.iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1.HeaderText = "ID_номер музыкального инструмента";
            this.iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1.Name = "iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1";
            this.iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // номерМузыкальногоИнструментаDataGridViewTextBoxColumn
            // 
            this.номерМузыкальногоИнструментаDataGridViewTextBoxColumn.DataPropertyName = "Номер музыкального инструмента";
            this.номерМузыкальногоИнструментаDataGridViewTextBoxColumn.HeaderText = "Номер музыкального инструмента";
            this.номерМузыкальногоИнструментаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерМузыкальногоИнструментаDataGridViewTextBoxColumn.Name = "номерМузыкальногоИнструментаDataGridViewTextBoxColumn";
            this.номерМузыкальногоИнструментаDataGridViewTextBoxColumn.Width = 125;
            // 
            // расшифровкаDataGridViewTextBoxColumn
            // 
            this.расшифровкаDataGridViewTextBoxColumn.DataPropertyName = "Расшифровка";
            this.расшифровкаDataGridViewTextBoxColumn.HeaderText = "Расшифровка";
            this.расшифровкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.расшифровкаDataGridViewTextBoxColumn.Name = "расшифровкаDataGridViewTextBoxColumn";
            this.расшифровкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерМузыкальногоИнструментаBindingSource
            // 
            this.номерМузыкальногоИнструментаBindingSource.DataMember = "Номер музыкального инструмента";
            this.номерМузыкальногоИнструментаBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // номер_музыкального_инструментаTableAdapter
            // 
            this.номер_музыкального_инструментаTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПроизводительDataGridViewTextBoxColumn1,
            this.названиеПроизводителяDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.производительBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(13, 325);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(430, 150);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // iDПроизводительDataGridViewTextBoxColumn1
            // 
            this.iDПроизводительDataGridViewTextBoxColumn1.DataPropertyName = "ID_Производитель";
            this.iDПроизводительDataGridViewTextBoxColumn1.HeaderText = "ID_Производитель";
            this.iDПроизводительDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDПроизводительDataGridViewTextBoxColumn1.Name = "iDПроизводительDataGridViewTextBoxColumn1";
            this.iDПроизводительDataGridViewTextBoxColumn1.Width = 125;
            // 
            // названиеПроизводителяDataGridViewTextBoxColumn
            // 
            this.названиеПроизводителяDataGridViewTextBoxColumn.DataPropertyName = "Название производителя";
            this.названиеПроизводителяDataGridViewTextBoxColumn.HeaderText = "Название производителя";
            this.названиеПроизводителяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеПроизводителяDataGridViewTextBoxColumn.Name = "названиеПроизводителяDataGridViewTextBoxColumn";
            this.названиеПроизводителяDataGridViewTextBoxColumn.Width = 125;
            // 
            // производительBindingSource
            // 
            this.производительBindingSource.DataMember = "Производитель";
            this.производительBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // производительTableAdapter
            // 
            this.производительTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(581, 595);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 31);
            this.button5.TabIndex = 12;
            this.button5.Text = "Вернутся";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(581, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Заменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UchaisiaAdditional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 638);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UchaisiaAdditional";
            this.Text = "Дополнительно";
            this.Load += new System.EventHandler(this.UchaisiaAdditional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.музыкальныйИнструментBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётМузыкальныхИнстурментовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номерМузыкальногоИнструментаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производительBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМузыкальныйИнструментDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеМузыкальногоИнструментаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDНомерМузыкальногоИнструментаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроизводительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Учащийся;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDномерМузыкальногоИнструментаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерМузыкальногоИнструментаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расшифровкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроизводительDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПроизводителяDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
        public System.Windows.Forms.BindingSource музыкальныйИнструментBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Музыкальный_инструментTableAdapter музыкальный_инструментTableAdapter;
        public System.Windows.Forms.BindingSource учётМузыкальныхИнстурментовBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Учёт_музыкальных_инстурментовTableAdapter учёт_музыкальных_инстурментовTableAdapter;
        public System.Windows.Forms.BindingSource номерМузыкальногоИнструментаBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.Номер_музыкального_инструментаTableAdapter номер_музыкального_инструментаTableAdapter;
        public System.Windows.Forms.BindingSource производительBindingSource;
        public База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.ПроизводительTableAdapter производительTableAdapter;
    }
}