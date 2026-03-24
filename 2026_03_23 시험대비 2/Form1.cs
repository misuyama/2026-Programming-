using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_23_시험대비_2
{
    //국어(txtKor), 수학(txtMath), 영어(txtEng) 점수를 입력받아 합계를 txtSum.Text에, 평균(소수점 1자리)을 txtAvg.Text에 출력하는 버튼 클릭 이벤트를 완성하시오.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("계속 진행하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(txtkr.Text) + Convert.ToDouble(txtma.Text) + Convert.ToDouble(txten.Text);
            double summ = sum / 3;
            textBox4.Text = sum.ToString();
            textBox5.Text = summ.ToString("0.0");
        }
    }
}
