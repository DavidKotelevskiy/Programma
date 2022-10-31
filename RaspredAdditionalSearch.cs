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
    public partial class RaspredAdditionalSearch : Form
    {
        public RaspredAdditionalSearch()
        {
            InitializeComponent();
        }

        private void buttonSearchGroup_Click(object sender, EventArgs e)
        {
            RaspredAdditional raspredAdditional = this.Owner as RaspredAdditional;
            if (raspredAdditional != null)
            {
                for (int i = 0; i < raspredAdditional.dataGridView2.RowCount; i++)
                {
                    raspredAdditional.dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < raspredAdditional.dataGridView2.ColumnCount; j++)
                        if (raspredAdditional.dataGridView2.Rows[i].Cells[j].Value != null)
                            if (raspredAdditional.dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                raspredAdditional.dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
        private void buttonSearchDirection_Click(object sender, EventArgs e)
        {
            RaspredAdditional raspredAdditional = this.Owner as RaspredAdditional;
            if (raspredAdditional != null)
            {
                for (int i = 0; i < raspredAdditional.dataGridView3.RowCount; i++)
                {
                    raspredAdditional.dataGridView3.Rows[i].Selected = false;
                    for (int j = 0; j < raspredAdditional.dataGridView3.ColumnCount; j++)
                        if (raspredAdditional.dataGridView3.Rows[i].Cells[j].Value != null)
                            if (raspredAdditional.dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                            {
                                raspredAdditional.dataGridView3.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
