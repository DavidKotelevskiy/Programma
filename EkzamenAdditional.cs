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
    public partial class EkzamenAdditional : Form
    {
        public EkzamenAdditional()
        {
            InitializeComponent();
        }

        private void EkzamenAdditional_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Тип_экзамена". При необходимости она может быть перемещена или удалена.
            this.тип_экзаменаTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Тип_экзамена);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Экзаменатор". При необходимости она может быть перемещена или удалена.
            this.экзаменаторTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Экзаменатор);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            экзаменаторTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
            тип_экзаменаTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EkzamenAdditionalSearch ekzamenAdditionalSearch = new EkzamenAdditionalSearch();
            ekzamenAdditionalSearch.Owner = this;
            ekzamenAdditionalSearch.Show();
        }

        private void buttonDeleteLastRows_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            dataGridView1.Refresh();


            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
            dataGridView2.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EkzamenAdditionalReplace ekzamenAdditionalReplace = new EkzamenAdditionalReplace();
            ekzamenAdditionalReplace.Owner = this;
            ekzamenAdditionalReplace.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Ekzamen ekzamen = new Ekzamen();
            ekzamen.ShowDialog();
        }
    }
}
