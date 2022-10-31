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
    public partial class UchaisiaAdditionalSearch : Form
    {
        public UchaisiaAdditionalSearch()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UchaisiaAdditional raspredAdditional = this.Owner as UchaisiaAdditional;
            if (raspredAdditional != null)
            {
                for (int i = 0; i < raspredAdditional.dataGridView3.RowCount; i++)
                {
                    raspredAdditional.dataGridView3.Rows[i].Selected = false;
                    for (int j = 0; j < raspredAdditional.dataGridView3.ColumnCount; j++)
                        if (raspredAdditional.dataGridView3.Rows[i].Cells[j].Value != null)
                            if (raspredAdditional.dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(textBox3.Text))
                            {
                                raspredAdditional.dataGridView3.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UchaisiaAdditional raspredAdditional = this.Owner as UchaisiaAdditional;
            if (raspredAdditional != null)
            {
                for (int i = 0; i < raspredAdditional.dataGridView1.RowCount; i++)
                {
                    raspredAdditional.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < raspredAdditional.dataGridView1.ColumnCount; j++)
                        if (raspredAdditional.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (raspredAdditional.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                raspredAdditional.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UchaisiaAdditional raspredAdditional = this.Owner as UchaisiaAdditional;
            if (raspredAdditional != null)
            {
                for (int i = 0; i < raspredAdditional.dataGridView2.RowCount; i++)
                {
                    raspredAdditional.dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < raspredAdditional.dataGridView2.ColumnCount; j++)
                        if (raspredAdditional.dataGridView2.Rows[i].Cells[j].Value != null)
                            if (raspredAdditional.dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                            {
                                raspredAdditional.dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
