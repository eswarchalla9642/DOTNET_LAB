//Write a program ta o simple calculator using a windows application.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String m1, m2, m3, m4, m5, m6, m7, m8;
        int a;

        private void x7_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "7";
        }

        private void x8_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "8";
        }

        private void x9_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "9";
        }

        private void x0_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "0";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            m3 = x.Text;
            x.Clear();
            a = 2;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            m5 = x.Text;
            x.Clear();
            a = 3;
        }

        private void div_Click(object sender, EventArgs e)
        {
            m7 = x.Text;
            x.Clear();
            a = 4;

        }

        private void res_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                m2= x.Text;
                int a1=int.Parse(m1) + int.Parse(m2);
                x.Text = a1.ToString();
            }
            else if (a == 2)
            {
                m4 = x.Text;
                int a2 = int.Parse(m3) - int.Parse(m4);
                x.Text = a2.ToString();
            }
            else if(a == 3)
            {
                m6 = x.Text;
                int a3 = int.Parse(m5) * int.Parse(m6);
                x.Text = a3.ToString();
            }
            else if (a == 4)
            {
                m8 = x.Text;
                int a4 = int.Parse(m7) / int.Parse(m8);
                x.Text = a4.ToString();
            }
            else { }
        }

        private void add_Click(object sender, EventArgs e)
        {
            m1 = x.Text;
            x.Clear();
            a = 1;
        }

        private void x6_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "6";
        }

        private void x5_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "5";
        }

        private void x4_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "4";
        }

        private void x3_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "3";
        }

        private void x2_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "2";
        }

       
        private void x1_Click(object sender, EventArgs e)
        {
            x.Text = x.Text + "1";
        }
    }
}
