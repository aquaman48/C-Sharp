using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;


namespace MathApp
{
    public partial class AreaCalculator : Form
    {
        
        public AreaCalculator()
        {
            InitializeComponent();
        }

        private void AreaCalculator_Load(object sender, EventArgs e)
        {
            string title = "IMPORTANT PLEASE READ!!!!";
            string message = "This application enables you to compute different measurements" +
                             " for three figure types." +
                            " You will be asked to select a figure and then asked " +
                            "to enter it\'s unique measurement(s). " +
                            " The area will be calculated and displayed.";

            MessageBox.Show(message, title);

                
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            lblInput.Visible = true;
            
            
            lblResult.Visible = true;
            textBox1.Visible = true;
            btnResult.Visible = true;
           


        }

        private void btnCylinder_Click(object sender, EventArgs e)
        {
            lblInput.Visible = true;

            lblResult.Visible = true;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            lblInput.Visible = true;

            lblResult.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string q = textBox1.Text;

            lblResult.Text = q;
        }
    }
        
    }

