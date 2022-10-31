
namespace WindowsFormsApp2
{
    partial class Uchaisia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uchaisia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDУчащийсяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактнаяИнформацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учащийсяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet();
            this.учащийсяTableAdapter = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.УчащийсяTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учащийсяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDУчащийсяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.контактнаяИнформацияDataGridViewTextBoxColumn,
            this.годРожденияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.учащийсяBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDУчащийсяDataGridViewTextBoxColumn
            // 
            this.iDУчащийсяDataGridViewTextBoxColumn.DataPropertyName = "ID_Учащийся";
            this.iDУчащийсяDataGridViewTextBoxColumn.HeaderText = "ID_Учащийся";
            this.iDУчащийсяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDУчащийсяDataGridViewTextBoxColumn.Name = "iDУчащийсяDataGridViewTextBoxColumn";
            this.iDУчащийсяDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // контактнаяИнформацияDataGridViewTextBoxColumn
            // 
            this.контактнаяИнформацияDataGridViewTextBoxColumn.DataPropertyName = "Контактная информация";
            this.контактнаяИнформацияDataGridViewTextBoxColumn.HeaderText = "Контактная информация";
            this.контактнаяИнформацияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.контактнаяИнформацияDataGridViewTextBoxColumn.Name = "контактнаяИнформацияDataGridViewTextBoxColumn";
            this.контактнаяИнформацияDataGridViewTextBoxColumn.Width = 125;
            // 
            // годРожденияDataGridViewTextBoxColumn
            // 
            this.годРожденияDataGridViewTextBoxColumn.DataPropertyName = "Год рождения";
            this.годРожденияDataGridViewTextBoxColumn.HeaderText = "Год рождения";
            this.годРожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.годРожденияDataGridViewTextBoxColumn.Name = "годРожденияDataGridViewTextBoxColumn";
            this.годРожденияDataGridViewTextBoxColumn.Width = 125;
            // 
            // учащийсяBindingSource
            // 
            this.учащийсяBindingSource.DataMember = "Учащийся";
            this.учащийсяBindingSource.DataSource = this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
            // 
            // база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet
            // 
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.DataSetName = "База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet";
            this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учащийсяTableAdapter
            // 
            this.учащийсяTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(240, 459);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Выход";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(126, 459);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Сохранение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(240, 428);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Дополнительно";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonShowAdditional_Click);
            // 
            // Uchaisia
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
            this.Name = "Uchaisia";
            this.Text = "Учащийся";
            this.Load += new System.EventHandler(this.Uchaisia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учащийсяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private База_данных_музыкальной_школы_им_ШвагенвагенсаDataSet база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet;
        private System.Windows.Forms.BindingSource учащийсяBindingSource;
        private База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.УчащийсяTableAdapter учащийсяTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУчащийсяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактнаяИнформацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
    }
}