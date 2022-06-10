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
    public partial class Form2 : Form
    {
        Form1 form;
        public static Boolean time(int[] ti)
        {
            if (ti[0] < 24 && ti[0] >= 0) if (ti[1] < 60 && ti[1] >= 0) return true;
                else return false;
            else return false;
        }
        DataGridView dgv;
        public Form2(DataGridView dgv1)
        {
            InitializeComponent();
            dgv = dgv1;
        }
        //2 3 4
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Trim(' ');
                textBox2.Text = textBox2.Text.Trim(' ');
                textBox3.Text = textBox3.Text.Trim(' ');
                textBox4.Text = textBox4.Text.Trim(' ');
                textBox5.Text = textBox5.Text.Trim(' ');
                textBox6.Text = textBox6.Text.Trim(' ');
                textBox7.Text = textBox7.Text.Trim(' ');
                textBox8.Text = textBox8.Text.Trim(' ');

                string[] db = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text };
                string[] data_out = (db[2]).Split('.', ',');
                string[] time_out = (db[3]).Split(':', ' ');
                string[] time_put = (db[4]).Split(':', ' ');
                int ticket = Convert.ToInt32(db[5]);
                int cup = Convert.ToInt32(db[6]);
                int plas = Convert.ToInt32(db[7]);
                int[] dataout = new int[3];
                int[] timeout = new int[2];
                int[] timeput = new int[2];
                for (int i = 0; 0 < 3; i++)
                {
                    dataout[i] = Convert.ToInt32(data_out[i]);
                    if (i < 2)
                    {
                        timeout[i] = Convert.ToInt32(time_out[i]);
                        timeput[i] = Convert.ToInt32(time_put[i]);
                    }
                    else break;
                }
                if ((2023 > dataout[2]) && ((2 == dataout[1]) && (28 > dataout[1])) && (12 >= dataout[1]) && (dataout[0] > 0 && dataout[0] < 31))
                {
                    MessageBox.Show("Ошибка в дате");
                }

                if (!Form2.time(timeout)) MessageBox.Show("Неверное время");
                if (!Form2.time(timeput)) MessageBox.Show("Неверное время");
                if (!((ticket >= (cup + plas)) && (ticket >= 0) && (cup >= 0) && (plas >= 0))) MessageBox.Show("Ошибка в билетах");
                dgv.Rows.Add(db[0], db[1], db[2], db[3], db[4], db[5], db[6], db[7]);
                textBox1.Text = textBox2.Text = string.Empty;
                textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            }
            catch
            {
                MessageBox.Show("Неправильно ведены значения");
            }
        }
    }
}
