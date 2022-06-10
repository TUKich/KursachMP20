using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach2
{
    public partial class Form7 : Form
    {
        DataGridView dgv;
        public Form7(DataGridView dgv1)
        {
            InitializeComponent();
            dgv = dgv1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (textBox1.Text.Equals(dgv.Rows[i].Cells[0].Value))
                    {
                        dgv.Rows[i].Cells[6].Value = textBox3.Text;
                        dgv.Rows[i].Cells[7].Value = textBox4.Text;
                        dgv.Rows[i].Cells[5].Value = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
