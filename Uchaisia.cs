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
    public partial class Uchaisia : Form
    {
        public Uchaisia()
        {
            InitializeComponent();
        }

        private void Uchaisia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Учащийся". При необходимости она может быть перемещена или удалена.
            this.учащийсяTableAdapter.Fill(this.база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet.Учащийся);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            учащийсяTableAdapter.Update(база_данных_музыкальной_школы_им_ШвагенвагенсаDataSet);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Ekzamen ekzamen = new Ekzamen();
            ekzamen.ShowDialog();
        }

        private void buttonShowAdditional_Click(object sender, EventArgs e)
        {
            UchaisiaAdditional uchaisiaAdditional = new UchaisiaAdditional();
            uchaisiaAdditional.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            dataGridView1.Refresh();

        }
    }
}
