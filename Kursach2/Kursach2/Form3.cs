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
    public partial class Form3 : Form
    {
        DataGridView dgv;
        public Form3(DataGridView dgv1)
        {
            InitializeComponent();
            dgv = dgv1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] db = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, };
                if (radioButton1.Checked == true)
                {
                    int indexr = 0;
                    Boolean yr = false;
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (db[0].Equals(dgv.Rows[i].Cells[0].Value))
                            if (db[1].Equals(dgv.Rows[i].Cells[1].Value))
                                if (db[2].Equals(dgv.Rows[i].Cells[2].Value))
                                    if (db[3].Equals(dgv.Rows[i].Cells[3].Value))
                                        if (db[4].Equals(dgv.Rows[i].Cells[4].Value))
                                        { indexr = i; yr = true; };

                    }
                    if (yr)
                    {
                        dgv.Rows.RemoveAt(indexr);
                        MessageBox.Show("Операция произошла успешно");
                    }
                    else MessageBox.Show("Нет таких данных в таблице");
                }
                if (radioButton2.Checked == true)
                {

                    Boolean yr = false;
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (db[1].Equals(dgv.Rows[i].Cells[1].Value)) { dgv.Rows.RemoveAt(i); yr = true; };
                    }
                    if (yr)
                    {
                        MessageBox.Show("Операция произошла успешно");
                    }
                    else MessageBox.Show("Нет таких данных в таблице");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox1.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
            }
        }
    }
}
