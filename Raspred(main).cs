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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Таблица_распределения_поступающих". При необходимости она может быть перемещена или удалена.
            this.таблица_распределения_поступающихTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Таблица_распределения_поступающих);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            таблица_распределения_поступающихTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Uchaisia uchaisia = new Uchaisia();
            uchaisia.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Ekzamen ekzamen = new Ekzamen();
            ekzamen.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RaspredAdditional raspredAdditional = new RaspredAdditional();
            raspredAdditional.ShowDialog();
        }

        private void buttonShowSearch_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Owner = this;
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            dataGridView1.Refresh();
        }
    }
}
