using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_25_susi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx1.Items.Add("아메리카노"); //cbx1에 아이템을 넣는 코드
            cbx1.Items.Add("카페라테");   //cbx1에 아이템을 넣는 코드
            cbx1.Items.Add("카푸티노");   //cbx1에 아이템을 넣는 코드
        }

        private void sum_Click(object sender, EventArgs e)
        {

            double count = double.Parse(cout1.Text); //개수를 변환하는것
            double result = 0; //초기값은 0이고 여기에 커피값을 추가하는 변수
            double ssum = 0; // 전체금액에다 커피값을 빼는 변수

            if (cbx1.Text == "아메리카노")
            {
                result += 3000;
            }

            else if (cbx1.Text == "카페라테")
            {
                result += 4000;
            }
            else if (cbx1.Text == "카푸티노")
            {
                result += 4500;
            }

            double plus = count * result; // 할인금액 전 최종 금액



            if (count >= 3)
            {

                result = plus * 0.1;  //커피가 3개이상일 시 주문금액에다가 10%를 할인해주는 과정
            }

            double ssum1 = plus - result; // 주문금액에다가 할인금액을 뺀 최종금액.







            and.Text = "주문자 : " + name1.Text + "\r\n" +
                "주문내용 : " + cbx1.Text + "*" + count.ToString() + "\r\n" +
                "주문금액 : " + plus + "\r\n" +
                "할인금액 : " + result + "\r\n" +
                "결재금액 : " + ssum1;

        }

        private void re_Click(object sender, EventArgs e)
        {
            name1.Text = ""; //초기화하는과정
            cbx1.Text = "";  //초기화하는과정
            cout1.Text = "";  //초기화하는과정
            and.Text = "";  //초기화하는과정
        }
    }
}
