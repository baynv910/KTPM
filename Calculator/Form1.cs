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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);            double b = double.Parse(txtNum2.Text);            double res = a + b;            txtRes.Text = res.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);            double b = double.Parse(txtNum2.Text);            double res = a - b;            txtRes.Text = res.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);            double b = double.Parse(txtNum2.Text);            double res = a * b;            txtRes.Text = res.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);            double b = double.Parse(txtNum2.Text);            double res;            if (b == 0)                txtRes.Text = "Error Div 0";            else
            {
                res = a / b;
                txtRes.Text = res.ToString();
            }
        }
    }
}
