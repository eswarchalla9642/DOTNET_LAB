// Program to display the addition,subtraction,multiplication,division using the windows application.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithematic
{
    public partial class Form1 : Form
    {
        int a, b, c;

        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void add_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(num1.Text);
            b = Convert.ToInt32(num2.Text);
            c = a + b;
            res.Text = Convert.ToString(c);
        }
        private void sub_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(num1.Text);
            b = Convert.ToInt32(num2.Text);
            c = a - b;
            res.Text = Convert.ToString(c);
        }

        private void mul_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(num1.Text);
            b = Convert.ToInt32(num2.Text);
            c = a * b;
            res.Text = Convert.ToString(c);
        }

        private void div_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(num1.Text);
            b = Convert.ToInt32(num2.Text);
            c = a / b;
            res.Text = Convert.ToString(c);
        }
    }
}
