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

namespace _2026_03_10_BMI_2_
{
    public partial class BMI측정 : Form
    {
        public BMI측정()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //hi라는 변수에 textBox2(문자열)을 상수로 바꿔줘서 넣는다.
            double hi = double.Parse(textBox2.Text);

            //wi라는 변수에 textBox1(문자열)을 상수로 바꿔줘서 넣는다.
            double wi = double.Parse(textBox1.Text);

            //원본 hi는 cm로 입력 받았기에 이것을 100으로 나눈 값인 hii를 이용해 계산하는데 이용한다.
            double hii = hi / 100;

            double bmi = wi / (hii * hii);

            //여기서 bmi1은 숨겨진 label3을 말한다. 안보이지만, 필요할 때 값을 입력하면 된다.
           // bmi1.Text = bmi.ToString();
            bmi1.Text = String.Format("{0:F1}", bmi);

            if (bmi < 18.5)
            {
                bmi2.Text = "저체중";
                pictureBox1.BackColor = Color.White;
            }
            else if (bmi > 18.6 && bmi < 23)
            {
                bmi2.Text = "정상";
                pictureBox1.BackColor = Color.Black;
            }
            else if (bmi > 23 && bmi < 25)
            {
                bmi2.Text = "과체중";
                pictureBox1.BackColor = Color.Yellow;
            }
            else
            {

                bmi2.Text = "비만";
                pictureBox1.BackColor = Color.Red;
            }

        }
    }
}
