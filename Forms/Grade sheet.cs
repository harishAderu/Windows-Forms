using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class Grade_sheet : Form
    {
        public Grade_sheet()
        {
            InitializeComponent();
        }

        private void Grade_sheet_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void result()
        {
            int m = Convert.ToInt32(textBox1.Text);
            int p = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            textBox4.Text = (m + p + c).ToString();
            textBox5.Text = ((m + p + c) / 3).ToString();
            if (m + p + c >= 150)
            {
                
                textBox6.Text = "Pass";
                
                    if ((m + p + c) > 250)
                    {
                        textBox7.Text = "A";
                    }
                    else if ((m + p + c) > 200)
                    {
                        textBox7.Text = "B";
                    }
                    else
                        textBox7.Text = "D";
                
            }
            else
            {
                textBox6.Text = "Fail";
                
                textBox7.Text = "NA";
            }
            
            
                        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            result();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grade_sheet wdw = new Grade_sheet();
            wdw.Show();
            this.Dispose(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Closing Window", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();

        }
    }
}
