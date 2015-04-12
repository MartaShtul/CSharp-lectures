using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0/255");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-128/127");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-32768/32767");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0/65535");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-2147483648/2147483647");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0u/4294967295U");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-9223372036854775808L/9223372036854775807L");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0ul/18446744073709551615UL");
        }
    }
}
