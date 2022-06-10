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
    public partial class Form6 : Form
    {
        DataGridView dgv;
        public Form6(DataGridView dgv1)
        {
            InitializeComponent();
            dgv = dgv1;
            if (!dataGridView1.Columns.Contains("Номер"))
            {
                dataGridView1.Columns.Add("Номер", "Номер");
                dataGridView1.Columns.Add("Станция наз", "Станция наз");
                dataGridView1.Columns.Add("Дата отп", "Дата отп");
                dataGridView1.Columns.Add("Время отп", "Время отп");
                dataGridView1.Columns.Add("Время приб", "Время приб");
                dataGridView1.Columns.Add("Билеты", "Билеты");
                dataGridView1.Columns.Add("Купе", "Купе");
                dataGridView1.Columns.Add("Плацкарт", "Плацкарт");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                if (!dataGridView1.Columns.Contains("Номер"))
                {
                    dataGridView1.Columns.Add("Номер", "Номер");
                    dataGridView1.Columns.Add("Станция наз", "Станция наз");
                    dataGridView1.Columns.Add("Дата отп", "Дата отп");
                    dataGridView1.Columns.Add("Время отп", "Время отп");
                    dataGridView1.Columns.Add("Время приб", "Время приб");
                    dataGridView1.Columns.Add("Билеты", "Билеты");
                    dataGridView1.Columns.Add("Купе", "Купе");
                    dataGridView1.Columns.Add("Плацкарт", "Плацкарт");

                }
                DateTime data1 = new DateTime();
                DateTime data2 = new DateTime();
                data1 = Convert.ToDateTime(textBox1.Text);
                data2 = Convert.ToDateTime(textBox2.Text);
                DateTime dda1 = new DateTime();
                DateTime dda2 = new DateTime();
                DataGridViewRow row;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (textBox3.Text.Equals(dgv.Rows[i].Cells[1].Value))
                        if ((dda1 = Convert.ToDateTime(dgv.Rows[i].Cells[3].Value)) >= data1)
                            if ((dda2 = Convert.ToDateTime(dgv.Rows[i].Cells[4].Value)) <= data2)
                            {
                                dataGridView1.Rows.Add(dgv.Rows[i].Cells[0].Value,
                                    dgv.Rows[i].Cells[1].Value,
                                    dgv.Rows[i].Cells[2].Value,
                                    dgv.Rows[i].Cells[3].Value,
                                    dgv.Rows[i].Cells[4].Value,
                                    dgv.Rows[i].Cells[5].Value,
                                    dgv.Rows[i].Cells[6].Value,
                                    dgv.Rows[i].Cells[7].Value);
                            };
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
