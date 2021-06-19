/* FrmFileAccess.cs   
 * This application reads
 * integers from a text file,
 * displays the number of values,
 * the average, smallest and largest
 * value.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace FileAccessApp
{
    public partial class FrmFileAccess : Form
    {
        private StreamReader inFile;
        //private int[] numbers;
        private List<string> userName = new List<string>();
        //private string x;

        public FrmFileAccess()
        {
            InitializeComponent();
        }

        private void FrmFileAccess_Load(object sender, EventArgs e)
        {
            string inValue;
            //numbers = new int[10];
            int i = 0;

            if (File.Exists("numbers.txt"))
            {
                try
                {
                    inFile = new StreamReader("numbers.txt");
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        userName.Add(inValue);
                        //numbers[i] += int.Parse(inValue);
                        i++;
                    }
                    lblResult.Text = "Number of Users in file: " + i;
                }

                catch (System.IO.IOException exc)
                {
                    lblResult.Text = exc.Message;
                }
            }

            else
            {
                lblResult.Text = "File Unavailable";
            }

            lblResult.Visible = true;
        }

        private void FrmFileAccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                inFile.Close();
            }

            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }

        private void btnDisplayUsers_Click(object sender, EventArgs e)
        {
            results.Visible = true;
            foreach(string user in userName)
            {
                results.Text = results.Text + user + Environment.NewLine;

            }
            lblResult.Text = "";
        }
    }
}