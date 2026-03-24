using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_23_bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text); //키 입력
            double b = double.Parse(textBox2.Text); // 몸무계 입력

            double c = a / 100;    // 키를 100으로 나눠주고
            double d = b / (c * c); //bmi 계산
            textBox3.Text = d.ToString("0.0"); 

            if (d < 18.5)
            {
                textBox4.Text = "저체중입니다.";
                pictureBox1.BackColor = Color.White;
            }
            else if (18.5 < d && d < 23)
            {
                textBox4.Text = "정상입니다.";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (23 < d && d < 25)
            {
                textBox4.Text = "과체중입니다.";
                pictureBox1.BackColor = Color.Green;
            }
            else if (d >25)
            {
                textBox4.Text = "비만입니다.";
                pictureBox1.BackColor= Color.Red;
            }
        }
    }
}
