using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textbox1을 문자열로 입력 받은 것을 숫자열로 바뀌어준다.
            double HI = double.Parse(textBox1.Text);

            //textbox2을 문자열로 입력 받은 것을 숫자열로 바뀌어준다.
            double KG = double.Parse(textBox2.Text);
            
            //변환해준다. 왜? cm로 받았기 때문이다.
            double CHHI = HI / 100;

            //bmi 계산식
            double bmi = KG / (CHHI * CHHI);

            txtR.Text = "BMI = " + bmi.ToString();

            if (bmi < 18.5)
                label4.Text = "저체중";
            else if (bmi < 23)
                label4.Text = "정상";
            else if (bmi < 25)
                label4.Text = "과체중";
            else
                label4.Text = "비만";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
