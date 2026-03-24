using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_22_성적계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text);
            double vudrbs = sum / 3;
            textBox4.Text = sum.ToString();
            textBox5.Text = vudrbs.ToString("0.0");

        }
    }
}
