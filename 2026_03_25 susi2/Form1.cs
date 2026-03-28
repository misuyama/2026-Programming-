using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_25_susi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {

            double number1 = double.Parse(number.Text); //학번을 입력받고 숫자열로 바꾼다.
            double middle1 = double.Parse(middle.Text); // 중간고사 점수를 입력받고 숫자열로 바꾼다.
            double rast1 = double.Parse(rast.Text); // 기말고사 점수를 입력받고 숫자열로 바꾼다.
            double sugje1 = double.Parse(sugje.Text); // 과제 점수를 입력받고 숫자열로 바꾼다.

            double sum = sugje1 + middle1 + rast1; // 중간 + 기말 + 과제를 다 더한다.
            double blance = sum / 3; // 다 더한 값을 나눈다.
            string abcde = ""; // 학점 생성 문자열

            if (blance >= 90)
            {
                abcde = "A";
            }

            else if (blance >= 80)
            {
                abcde = "B";
            }

            else if (blance >= 70)
            {
                abcde = "C";
            }
            else if (blance >= 60)
            {
                abcde = "D";
            }
            else if (blance >= 50)
            {
                abcde = "E";
            }
            else
            {
                abcde = "F";
            }





                result.Text = "학번 : " + number1 + "\r\n" +
                               "이름 : " + name1.Text + "\r\n" +
                               "총점 : " + sum + "\r\n" +
                               "평균 : " + blance.ToString("0.0") + "\r\n" +
                               "학점 : " + abcde + "\r\n";

        }

        private void cleararea_Click(object sender, EventArgs e)
        {
            name1.Text = "";
            middle.Text = "";
            number.Text = "";
            rast.Text = "";
            sugje.Text = "";
            result.Text = "";
        }
    }
}
