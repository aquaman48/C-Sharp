using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double val1,
                val2;
            val1 = GetFirstValue();
            val2 = GetSecondValue();

            if (val1 > 0 && val2 > 0)
            {
                lblResult.ForeColor = Color.Yellow;
                lblResult.Text = "Result = " + (val1 + val2).ToString();
            }
            lblResult.Visible = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double val1,
                val2;
            val1 = GetFirstValue();
            val2 = GetSecondValue();

            if (val1 > 0 && val2 > 0)
            {
                lblResult.ForeColor = Color.Yellow;
                lblResult.Text = "Result = " + (val1 * val2).ToString();
            }
            lblResult.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxValue1.Text = "";
            txtBxValue2.Text = "";
            lblResult.Text = "";
            txtBxValue1.Focus();
            lblResult.Visible = false;
        }

        public double GetFirstValue()
        {
            double val1;
            while (double.TryParse(txtBxValue1.Text, out val1) == false)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and > 0.";
                txtBxValue1.Text = "0";
                txtBxValue1.Focus();
            }
            return val1;
        }

        public double GetSecondValue()
        {
            double val2;
            while (double.TryParse(txtBxValue2.Text, out val2) == false)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and > 0.";
                txtBxValue2.Text = "0";
                txtBxValue2.Focus();
            }
            return val2;
        }
    }
}
