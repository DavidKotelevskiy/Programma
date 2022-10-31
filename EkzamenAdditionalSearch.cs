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
    public partial class EkzamenAdditionalSearch : Form
    {
        public EkzamenAdditionalSearch()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EkzamenAdditional ekzamenAdditional = this.Owner as EkzamenAdditional;
            if (ekzamenAdditional != null)
            {
                for (int i = 0; i < ekzamenAdditional.dataGridView1.RowCount; i++)
                {
                    ekzamenAdditional.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < ekzamenAdditional.dataGridView1.ColumnCount; j++)
                        if (ekzamenAdditional.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (ekzamenAdditional.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                            {
                                ekzamenAdditional.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkzamenAdditional ekzamenAdditional = this.Owner as EkzamenAdditional;
            if (ekzamenAdditional != null)
            {
                for (int i = 0; i < ekzamenAdditional.dataGridView2.RowCount; i++)
                {
                    ekzamenAdditional.dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < ekzamenAdditional.dataGridView2.ColumnCount; j++)
                        if (ekzamenAdditional.dataGridView2.Rows[i].Cells[j].Value != null)
                            if (ekzamenAdditional.dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                            {
                                ekzamenAdditional.dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }

        }
    }
}
