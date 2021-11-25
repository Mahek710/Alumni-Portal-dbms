using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlumniPortal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 33;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();

            }
            else if(radioButton2.Checked == true)
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();

            }
            else
            {
                label1.Text = "Select an option";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
