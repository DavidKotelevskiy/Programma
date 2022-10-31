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
    public partial class EkzamenReplace : Form
    {
        public EkzamenReplace()
        {
            InitializeComponent();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            Ekzamen ekzamen = this.Owner as Ekzamen;
            if (ekzamen != null)
            {
                DataRow nRow = ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[0].NewRow();
                int rc = ekzamen.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow["Дата экзамена"] = TbDateExem.Text;
                nRow["Оценка"] = TbEstimation.Text;
                ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[0].Rows.Add(nRow);
                ekzamen.тип_экзаменаTableAdapter.Update(ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Тип_экзамена);
                ekzamen.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Tables[0].AcceptChanges();
                ekzamen.dataGridView1.Refresh();
                TbDateExem.Text = "";
                TbEstimation.Text = "";
                
            }
        }
    }
}
