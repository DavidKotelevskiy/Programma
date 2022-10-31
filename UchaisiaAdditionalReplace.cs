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
    public partial class UchaisiaAdditionalReplace : Form
    {
        public UchaisiaAdditionalReplace()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {  try
            {
                UchaisiaAdditional ekzamen = this.Owner as UchaisiaAdditional;
                if (ekzamen != null)
                {
                    DataRow nRow = ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[1].NewRow();
                    int rc = ekzamen.dataGridView1.RowCount + 1;
                    nRow[0] = rc;
                    nRow["Наименование музыкального инструмента"] = TbMusInstr.Text;
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[1].Rows.Add(nRow);
                    ekzamen.музыкальный_инструментTableAdapter.Update(ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Музыкальный_инструмент);
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[1].AcceptChanges();
                    ekzamen.dataGridView1.Refresh();
                    TbMusInstr.Text = "";
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
            try
            {
                UchaisiaAdditional ekzamen = this.Owner as UchaisiaAdditional;
                if (ekzamen != null)
                {
                    DataRow nRow = ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[6].NewRow();
                    int rc = ekzamen.dataGridView4.RowCount + 1;
                    nRow[0] = rc;
                    nRow["Название производителя"] = TbCreation.Text;
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[6].Rows.Add(nRow);
                    ekzamen.производительTableAdapter.Update(ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Производитель);
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[6].AcceptChanges();
                    ekzamen.dataGridView4.Refresh();
                    TbCreation.Text = "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                UchaisiaAdditional ekzamen = this.Owner as UchaisiaAdditional;
                if (ekzamen != null)
                {
                    DataRow nRow = ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[3].NewRow();
                    int rc = ekzamen.dataGridView2.RowCount + 1;
                    nRow[0] = rc;
                    nRow["Номер музыкального инструмента"] = TbRass.Text;
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[3].Rows.Add(nRow);
                    ekzamen.номер_музыкального_инструментаTableAdapter.Update(ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Номер_музыкального_инструмента);
                    ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[3].AcceptChanges();
                    ekzamen.dataGridView2.Refresh();
                    TbRass.Text = "";
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

        private void TbTake_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
