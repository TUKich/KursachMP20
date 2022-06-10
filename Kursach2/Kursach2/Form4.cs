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
    public partial class Form4 : Form
    {
        DataGridView dgv;
        public Form4(DataGridView dgv1)
        {
            InitializeComponent();
            dgv = dgv1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] db = new string[] { textBox1.Text, textBox2.Text };
                int index = 0;
                Boolean yr = false;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (db[0].Equals(dgv.Rows[i].Cells[0].Value)) if (db[1].Equals(dgv.Rows[i].Cells[2].Value)) { yr = true; index = i; };

                }
                if (!yr)
                {
                    MessageBox.Show("Нет таких данных в таблице");
                }
                else
                {
                    string rtrtrtr = Convert.ToString(dgv.Rows[index].Cells[6].Value);
                    MessageBox.Show("Кол-во купейнных: "+rtrtrtr);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
