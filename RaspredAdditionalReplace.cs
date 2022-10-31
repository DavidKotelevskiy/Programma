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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {  try
            {
                RaspredAdditional main = this.Owner as RaspredAdditional;
                if (main != null)
                {
                    DataRow nRow = main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[4].NewRow();
                    int rc = main.dataGridView1.RowCount + 1;
                    nRow[0] = rc;
                    nRow["Наименование пола"] = tbPol.Text;
                    main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[4].Rows.Add(nRow);
                    main.полTableAdapter.Update(main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Пол);
                    main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[4].AcceptChanges();
                    main.dataGridView1.Refresh();
                    tbPol.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RaspredAdditional main = this.Owner as RaspredAdditional;
                if (main != null)
                {
                    DataRow nRow = main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[0].NewRow();
                    int rc = main.dataGridView2.RowCount + 1;
                    nRow[0] = rc;
                    nRow["Наименование группы"] = TbGroup.Text;
                    main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[0].Rows.Add(nRow);
                    main.группаTableAdapter.Update(main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Группа);
                    main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[0].AcceptChanges();
                    main.dataGridView2.Refresh();
                    tbPol.Text = "";
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
                RaspredAdditional main = this.Owner as RaspredAdditional;
                if (main != null)
                {
                    DataRow nRow = main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[2].NewRow();
                    int rc = main.dataGridView3.RowCount + 1;
                    nRow[0] = rc;
                    nRow["Наименование направления"] = TbSpecif.Text;
                    main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[2].Rows.Add(nRow);
                    main.направлениеTableAdapter.Update(main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Направление);
                    main.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[2].AcceptChanges();
                    main.dataGridView3.Refresh();
                    tbPol.Text = "";
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
    }
}
