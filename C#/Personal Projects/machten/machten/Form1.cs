using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace machten
{
    public partial class Form1 : Form
    {
        int g, h;
        string x;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = Convert.ToInt32(textBox1.Text);
            x = Convert.ToString(textBox1.Text);
            h = Convert.ToInt32(textBox2.Text);

            try
            {
                label2.Text = "";
                label3.Text = "";

                for(int q = 2; q <= h; q++)
                {
                    if (label3.Text == "")
                    {
                        label3.Text = x;
                        label3.Text = label3.Text + " x " + g;
                        x = label3.Text;
                    }
                    else
                    {
                        label3.Text = label3.Text + " x " + g;
                        x = label3.Text;
                    }


                    label2.Text = label2.Text + x + " = " + (g^q) +  "\r\n";
                }

                errorProvider1.SetError(textBox1, "");
            }
            catch
            {
                errorProvider1.SetError(textBox1, "not a integer value");
            }
        }
    }
}
