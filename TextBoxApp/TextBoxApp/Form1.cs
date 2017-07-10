using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Party People");




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string words = textBox1.Text;
            label1.Text = words;

        }

        private void Form1_Load(object sender, EventArgs e)
        
       
       
        {
            MessageBox.Show("It's almost lunch time");
            string words2 = textBox1.Text;
            label2.Text = words2;

            private void Form1_Load(object sender, EventArgs e)


        }

        private void btn3_Click(object sender, EventArgs e)

        {
            MessageBox.Show("We're doing C#");
            string words3 = textBox2.Text;
            label3.Text = words3;
        }

          



        
    }
}
