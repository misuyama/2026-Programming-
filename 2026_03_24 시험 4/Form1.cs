using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_24_시험_4
{
    public partial class Form1 : Form
    {
        //private RadioButton a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text);
            double b = a / 3;
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            string c = "";

            //if (radioButton1.Checked)
            //{
            //    c += "1학년입니다.";
            //
            //}
            //else if (radioButton2.Checked)
            //{
            //    c += "2학년입니다.";
            //}
            //else if (radioButton3.Checked)
            //{
            //    c += "3학년입니다.";
            //
            //}

            if (radioButton1.Checked)
            {

            }
            string n = "";
            n = string.Format("{0} 학년입니다. 점수 합계는 다음과 같습니다. {1}. 평균은 {2} 입니다.", c, a, b);
            MessageBox.Show(n);

        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
         //   a = radioButton1;
       // }
    }
}
