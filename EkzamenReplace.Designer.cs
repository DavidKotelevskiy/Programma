
namespace WindowsFormsApp2
{
    partial class EkzamenReplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkzamenReplace));
            this.label1 = new System.Windows.Forms.Label();
            this.TbDateExem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TbEstimation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.TableAdapterManager();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата проведения";
            // 
            // TbDateExem
            // 
            this.TbDateExem.Location = new System.Drawing.Point(25, 60);
            this.TbDateExem.Name = "TbDateExem";
            this.TbDateExem.Size = new System.Drawing.Size(309, 22);
            this.TbDateExem.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TbEstimation
            // 
            this.TbEstimation.Location = new System.Drawing.Point(25, 153);
            this.TbEstimation.Name = "TbEstimation";
            this.TbEstimation.Size = new System.Drawing.Size(309, 22);
            this.TbEstimation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оценка";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp2.База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ГруппаTableAdapter = null;
            this.tableAdapterManager1.Музыкальный_инструментTableAdapter = null;
            this.tableAdapterManager1.НаправлениеTableAdapter = null;
            this.tableAdapterManager1.Номер_музыкального_инструментаTableAdapter = null;
            this.tableAdapterManager1.ПолTableAdapter = null;
            this.tableAdapterManager1.Проведение_экзаменаTableAdapter = null;
            this.tableAdapterManager1.ПроизводительTableAdapter = null;
            this.tableAdapterManager1.Таблица_распределения_поступающихTableAdapter = null;
            this.tableAdapterManager1.Тип_экзаменаTableAdapter = null;
            this.tableAdapterManager1.УчащийсяTableAdapter = null;
            this.tableAdapterManager1.Учёт_музыкальных_инстурментовTableAdapter = null;
            this.tableAdapterManager1.ЭкзаменаторTableAdapter = null;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EkzamenReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 278);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TbEstimation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbDateExem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EkzamenReplace";
            this.Text = "Изменение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbDateExem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TbEstimation;
        private System.Windows.Forms.Label label2;
        private База_данных_музыкальной_школы_им_ШвагенвагенсаDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button3;
    }
}