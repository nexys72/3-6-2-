using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_практика_6_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
            
        {
            double input = double.Parse(textBox1.Text);
        label1.Text = (input* 1852).ToString();
    
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }
      
    }
}
