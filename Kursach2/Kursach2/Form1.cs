using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Kursach2
{
    public partial class Form1 : Form
    {
        
        public DataGridView Grid
        {
            get
            {
                return dataGridView1;
            }
        }
        struct train{
            public int Num;
            public string Station;
            public string date_out;
            public string time_out;
            public string time_put;
            public int ticket;
            public int ticket_cup;
            public int ticket_plas;
        }
        public Form1()
        {
            InitializeComponent();
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

        private void toolStripComboBox6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string Filename = openFileDialog1.FileName;
            var fileStream = openFileDialog1.OpenFile();
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tL = line.Split(' ');
                    Grid.Rows.Add(tL[0], tL[1], tL[2], tL[3], tL[4],tL[5], tL[6], tL[7]);
                }             
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки файла. Проверьте целостность таблицы.");
                
            }
        }

        private void toolStripComboBox5_Click(object sender, EventArgs e)
        {
            Stream st = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((st = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter wr = new StreamWriter(st);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {

                                wr.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + " ");

                            }
                            wr.WriteLine();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        wr.Close();
                    }
                    st.Close();
                }
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(dataGridView1);
            f.ShowDialog();
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(dataGridView1);
            f.ShowDialog();
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ReadOnly == true)
                dataGridView1.ReadOnly = false;
            else
                dataGridView1.ReadOnly = true;
            
        }

        private void колвоКупейныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(dataGridView1);
            f.ShowDialog();
        }

        private void колвоПоездовДоЗаднСтанцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5(dataGridView1);
            f.ShowDialog();
        }

        private void сортировкаПоИнтеревалуВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6(dataGridView1);
            f.ShowDialog();
        }

        private void изменитьСведенияОНаличиеБилетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f = new  Form7(dataGridView1);
            f.ShowDialog();
        }
    }
}
