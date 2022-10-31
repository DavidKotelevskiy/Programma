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
    public partial class RaspredAdditional : Form
    {
        public RaspredAdditional()
        {
            InitializeComponent();
        }

        private void RaspredAdditional_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Направление". При необходимости она может быть перемещена или удалена.
            this.направлениеTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Направление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Пол". При необходимости она может быть перемещена или удалена.
            this.полTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Пол);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            полTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
            группаTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
            направлениеTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }

        private void buttonShowSearch_Click(object sender, EventArgs e)
        {
            RaspredAdditionalSearch raspredAdditionalSearch = new RaspredAdditionalSearch();
            raspredAdditionalSearch.Owner = this;
            raspredAdditionalSearch.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            dataGridView1.Refresh();

            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
            dataGridView2.Refresh();

            dataGridView3.Rows.RemoveAt(dataGridView3.RowCount - 1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }
    }
}
