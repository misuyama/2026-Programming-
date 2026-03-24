using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmi_from
{
    public partial class txt : Form
    {
        public txt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //button1을 클릭했을 때 실행되는 이벤트 처리 함수
        private void button1_Click(object sender, EventArgs e) //버튼 1을 클릭하면
        {
            double h = double.Parse(txtH.Text); // txtH가 문자열이기에 호환이 안되서 double 바꿔주기 위해 Parse로 바꾸어준다.
            double w = double.Parse(txtW.Text); // txtH가 문자열이기에 호환이 안되서 double 바꿔주기 위해 Parse로 바꾸어준다.
            h /= 100;
            double bmi = w / (h * h);

            //.ToString()은 문자열로 바꾸어 준다.
            lastbmi.Text = "BMI = " + bmi.ToString(); 


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
