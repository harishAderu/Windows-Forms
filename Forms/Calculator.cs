using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            
        }
        public int result(string c)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            switch (c)
            {
                case "+":
                    return a + b;
                    break;
                case "-":
                    return a - b;
                    break;
                case "*":
                    return a * b;
                    break;
                case "/":
                    return a / b;
                    break;
                default:
                    return 0;
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = result("+").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = result("-").ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = result("*").ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = result("/").ToString();
        }
    }
}
