using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        int vx=0, vy=0;
        int speed=5;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Left += int.Parse(textBox1.Text);
            //label1.Top += int.Parse(textBox2.Text);
            label1.Left += vx * speed;
            label1.Top += vy * speed;

            if (label1.Left < 0)
            {
                vx = 1;
            }
            if (label1.Top < 0)
            {
                vy = 1;
            }
            if (label1.Left > 692)
            {
                vx = -1;
            }
            if (label1.Top > 381)
            {
                vy = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "-1";
            //textBox1.Text = "0";
            //vx = 0;
            vy = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "0";
            //textBox1.Text = "-1";
            vx = -1;
            //vy = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "0";
            //textBox1.Text = "1"; 
            vx = 1;
            //vy = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("" + ClientSize.Width);
            MessageBox.Show("" + ClientSize.Height);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "1";
            //textBox1.Text = "0";
            //vx = 0;
            vy = 1;
        }
    }
}
