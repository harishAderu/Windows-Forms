using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class QA : Form
    {
        public QA()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sco = 0;

            if (radioButton2.Checked) sco++;
            if (radioButton7.Checked) sco++;
            if (radioButton11.Checked) sco++;
            if (radioButton15.Checked) sco++;
            string msg = "your score is " + sco + "/4";
            label1.Text = msg;
            if (sco > 3) label1.ForeColor = Color.Green;
            else label1.ForeColor = Color.Red;
        }
    }
}
