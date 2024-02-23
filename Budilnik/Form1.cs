using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budilnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string music;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                music = open.FileName;
                textBox1.Text = open.SafeFileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = label5.Text + label4.Text + label6.Text + label7.Text + label8.Text;
            label5.Text = "00";
            label6.Text = "00";
            label8.Text = "00";
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == label2.Text)
            {
                axWindowsMediaPlayer1.URL = music;
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                button1.Hide();
                button2.Hide();
                button4.Hide();
                button5.Hide();
                button6.Hide();
                button7.Hide();
                button8.Hide();
                button9.Hide();
                button10.Hide();
                textBox1.Hide();
                button11.Show();
                button12.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string labell = label5.Text;
            int label = int.Parse(labell);
            if(label >= 23)
            {
                label5.Text = "00";
            }
            else
            {
                label++;
                labell = label.ToString();
                if(labell.Length == 1)
                {
                    label5.Text = "0" + labell;
                }
                else label5.Text = labell;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string labell = label6.Text;
            int label = int.Parse(labell);
            if (label >= 59)
            {
                label6.Text = "00";
            }
            else
            {
                label++;
                labell = label.ToString();
                if (labell.Length == 1)
                {
                    label6.Text = "0" + labell;
                }
                else label6.Text = labell;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string labell = label8.Text;
            int label = int.Parse(labell);
            if (label >= 59)
            {
                label8.Text = "00";
            }
            else
            {
                label++;
                labell = label.ToString();
                if (labell.Length == 1)
                {
                    label8.Text = "0" + labell;
                }
                else label8.Text = labell;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string labell = label5.Text;
            var label_0_chi = labell[0];
            var label_1_chi = labell[1];
            int label;
            if (label_0_chi == '0')
            {
                string labellstring = label_1_chi.ToString();
                label = int.Parse(labellstring);
                if (label == 0)
                {
                    label5.Text = "23";
                    label = 59;
                    return;
                }
                label--;
                label5.Text = "0" + label;
            }
            else
            {
                label = int.Parse(label5.Text);
                label--;
                if (label == 9) label5.Text = "0" + label;
                else label5.Text = label.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string labell = label6.Text;
            var label_0_chi = labell[0];
            var label_1_chi = labell[1];
            int label;
            if (label_0_chi == '0')
            {
                string labellstring = label_1_chi.ToString();
                label = int.Parse(labellstring);
                if (label == 0)
                {
                    label6.Text = "59";
                    label = 59;
                    return;
                }
                label--;
                label6.Text = "0" + label;
            }
            else
            {
                label = int.Parse(label6.Text);
                label--;
                if (label == 9) label6.Text = "0" + label;
                else label6.Text = label.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string labell = label8.Text;
            var label_0_chi = labell[0];
            var label_1_chi = labell[1];
            int label;
            if (label_0_chi == '0')
            {
                string labellstring = label_1_chi.ToString();
                label = int.Parse(labellstring);
                if (label == 0)
                {
                    label8.Text = "59";
                    label = 59;
                    return;
                }
                label--;
                label8.Text = "0" + label;
            }
            else
            {
                label = int.Parse(label8.Text);
                label--;
                if (label == 9) label8.Text = "0" + label;
                else label8.Text = label.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button11.Hide();
            button12.Hide();
            label9.Hide();
            button11.BackColor = Color.FromArgb(80, 0, 0, 0);
            button12.BackColor = Color.FromArgb(80, 0, 0, 0);
            button1.BackColor = Color.FromArgb(80, 0, 0, 0);
            button2.BackColor = Color.FromArgb(80, 0, 0, 0);
            button4.BackColor = Color.FromArgb(80, 0, 0, 0);
            button5.BackColor = Color.FromArgb(80, 0, 0, 0);
            button6.BackColor = Color.FromArgb(80, 0, 0, 0);
            button7.BackColor = Color.FromArgb(80, 0, 0, 0);
            button8.BackColor = Color.FromArgb(80, 0, 0, 0);
            button9.BackColor = Color.FromArgb(80, 0, 0, 0);
            button10.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer2.Stop();
            button12.Hide();
            button11.Hide();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            button1.Show();
            button2.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            textBox1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer3.Start();
            button11.Hide();
            button12.Hide();
            label9.Show();
            label9.Text = "10 MINUTGA TO'XTATILDI";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string minutt = "";
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int minu = DateTime.Now.Minute + 10;
            int secondd = DateTime.Now.Second;
            string second = secondd.ToString();
            if(second.Length == 1)
            {
                second = "0" + second;
            }
            if (minu > 50)
            {
                hour++;
                minute = minute - 10;
                minute = 60 - minute;
                minute = minute - 10;
                int minut = 10 - minute;
                minute = 0;
                minute = minute + minut;
                minutt = minute.ToString();
                minutt = "0" + minutt;
            }
            else
            {
                minute = minute + 10;
                minutt = minute.ToString();
            }
            bool exist = File.Exists("base/data.txt");
            if (exist)
            {
                File.Delete("base/data.txt");
                var file = File.Create("base/data.txt");
                file.Close();
                File.WriteAllText("base/data.txt", hour + ":" + minutt + ":" + second);
            }
            else
            {
                var file = File.Create("base/data.txt");
                file.Close();
                File.WriteAllText("base/data.txt", hour + ":" + minutt + ":" + second);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            string date = File.ReadAllText("base/data.txt");
            if (date == label1.Text)
            {
                axWindowsMediaPlayer1.URL = music;
                label9.Hide();
                button11.Show();
                button12.Show();
            }
        }
    }
}
