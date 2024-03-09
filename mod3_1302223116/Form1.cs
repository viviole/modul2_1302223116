using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod3_1302223116
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int global1;
        int global2;
        int counter = 0;
       

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = 1;
            label2.Text = label2.Text + number1;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number2 = 2;
            label2.Text = label2.Text + number2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number3 = 3;
            label2.Text = label2.Text + number3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number4 = 4;
            label2.Text = label2.Text + number4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number5 = 5;
            label2.Text = label2.Text + number5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number6 = 6;
            label2.Text = label2.Text + number6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number7 = 7;
            label2.Text = label2.Text + number7;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
               
        private void button10_Click_1(object sender, EventArgs e)
        {
            global1 = Int32.Parse(label2.Text);
            label2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            global2 = Int32.Parse(label2.Text);
            global1 = global1 + global2;
            label2.Text = "" + global1;
            // 1+2
            // [1, 2]
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int number11 = 0;
            label2.Text = label2.Text + number11;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int number8 = 8;
            label2.Text = label2.Text + number8;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int number9 = 9;
            label2.Text = label2.Text + number9;
        }
    }
}
