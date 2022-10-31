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
    public partial class Ekzamen : Form
    {
        public Ekzamen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Проведение_экзамена". При необходимости она может быть перемещена или удалена.
            this.проведение_экзаменаTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Проведение_экзамена);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Тип_экзамена". При необходимости она может быть перемещена или удалена.
            this.тип_экзаменаTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Тип_экзамена);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            проведение_экзаменаTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Uchaisia uchaisia = new Uchaisia();
            uchaisia.ShowDialog();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EkzamenAdditionalSearch ekzamenAdditionalSearch = new EkzamenAdditionalSearch();
            ekzamenAdditionalSearch.Owner = this;
            ekzamenAdditionalSearch.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EkzamenAdditional ekzamenAdditional = new EkzamenAdditional();
            ekzamenAdditional.Owner = this;
            ekzamenAdditional.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            dataGridView1.Refresh();

        }
    }
}
