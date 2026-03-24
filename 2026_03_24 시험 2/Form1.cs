using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_24_시험_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hi = Convert.ToDouble(txtHeight.Text);
            double we = double.Parse(txtWeight.Text);

            double really = hi / 100;
            double sum = we / (really * really);

            //lblResult.Text = sum.ToString("0.0");

            if (sum < 20)
            {
                lblResult.Text = "저체중";
                pictureBox1.BackColor = Color.White;
            }

            else if (20 <= sum && sum < 25)
            {
                lblResult.Text = "정상체중";
                pictureBox1.BackColor = Color.Blue;
            }

            else if (25 <= sum && sum < 30)
            {
                lblResult.Text = "경도비만";
                pictureBox1.BackColor = Color.Green;
            }

            else if (30 <= sum && sum < 40)
            {
                lblResult.Text = "비만";
                pictureBox1.BackColor = Color.Yellow;
            }

            else
            {
                lblResult.Text = "고도비만";
                pictureBox1.BackColor = Color.Red;
            }
        }
    }
}
