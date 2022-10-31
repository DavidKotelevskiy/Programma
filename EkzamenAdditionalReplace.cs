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
    public partial class EkzamenAdditionalReplace : Form
    {
        public EkzamenAdditionalReplace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EkzamenAdditional ekzamen = this.Owner as EkzamenAdditional;
                if (ekzamen != null)
                {
                    DataRow nRow = ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[11].NewRow();
                    int rc = ekzamen.dataGridView1.RowCount + 1;
                    nRow[0] = rc;
                    nRow["ФИО преподавателя"] = TbTeacher.Text;
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[11].Rows.Add(nRow);
                    ekzamen.экзаменаторTableAdapter.Update(ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Экзаменатор);
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[11].AcceptChanges();
                    ekzamen.dataGridView1.Refresh();
                    TbTeacher.Text = "";
                }
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Вы не сохранили предыдущею запись", "Сохранение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {

                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                EkzamenAdditional ekzamen = this.Owner as EkzamenAdditional;
                if (ekzamen != null)
                {
                    DataRow nRow = ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[8].NewRow();
                    int rc = ekzamen.dataGridView2.RowCount + 1;
                    nRow[0] = rc;
                    nRow["Наименование экзамена"] = TbExemName.Text;
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[8].Rows.Add(nRow);
                    ekzamen.тип_экзаменаTableAdapter.Update(ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Тип_экзамена);
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[8].AcceptChanges();
                    ekzamen.dataGridView2.Refresh();
                    TbExemName.Text = "";
                }
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Вы не сохранили предыдущею запись", "Сохранение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                   
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
