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
    public partial class Form5 : Form
    {
        DataGridView dgv;
        public Form5(DataGridView dgv1)
        {
            InitializeComponent();
            dgv = dgv1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (textBox1.Text.Equals(dgv.Rows[i].Cells[1].Value)) count++;
                }
                MessageBox.Show("Кол-во поездов до заданной станции: " + count);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
