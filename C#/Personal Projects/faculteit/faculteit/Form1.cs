using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faculteit
{
    public partial class Form1 : Form
    {
        int i;
        int y = 1;
        int u = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(numericUpDown1.Text)  + 1;

            try
            {
                if (label1.Text == "output")
                {
                    label1.Text = "";
                    for (int x = 1; x <= i; x++)
                    {

                        u = y * x;
                        label1.Text = label1.Text + y + " x " + x + " = " + u + "\n\r" ;
                        y = u;
                    }
                    errorProvider1.SetError(numericUpDown1, "");
                }
                else
                {
                    label1.Text = "";
                    y = 1;
                    u = 1;
                    for (int x = 1; x <= i; x++)
                    {

                        u = y * x;
                        label1.Text = label1.Text + y + " x " + x + " = " + u + "\n\r";
                        y = u;
                    }
                    errorProvider1.SetError(numericUpDown1, "");
                }
                errorProvider1.SetError(numericUpDown1, "");
            }
            catch
            {
                errorProvider1.SetError(numericUpDown1, "not a integer value");
            }
        }
    }
}
