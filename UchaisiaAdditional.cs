using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UchaisiaAdditional : Form
    {
        public UchaisiaAdditional()
        {
            InitializeComponent();
        }

        private void UchaisiaAdditional_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Номер_музыкального_инструмента". При необходимости она может быть перемещена или удалена.
            this.номер_музыкального_инструментаTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Номер_музыкального_инструмента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Учёт_музыкальных_инстурментов". При необходимости она может быть перемещена или удалена.
            this.учёт_музыкальных_инстурментовTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Учёт_музыкальных_инстурментов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Музыкальный_инструмент". При необходимости она может быть перемещена или удалена.
            this.музыкальный_инструментTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Музыкальный_инструмент);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            музыкальный_инструментTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
            номер_музыкального_инструментаTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
            производительTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
            учёт_музыкальных_инстурментовTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Uchaisia uchaisia = new Uchaisia();
            uchaisia.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            dataGridView1.Refresh();

            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
            dataGridView2.Refresh();

            dataGridView3.Rows.RemoveAt(dataGridView3.CurrentCell.RowIndex);
            dataGridView3.Refresh();

            dataGridView4.Rows.RemoveAt(dataGridView4.CurrentCell.RowIndex);
            dataGridView4.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UchaisiaAdditionalReplace af = new UchaisiaAdditionalReplace();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    
                }
        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
               
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
               
            }
        }
    }
}
