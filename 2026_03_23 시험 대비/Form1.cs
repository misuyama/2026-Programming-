using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2026_03_23_시험_대비
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요 : ", "알림");
                label3.Text = "로그인 실패";
            }
            else if (textBox1.Text == "abcd" && textBox2.Text == "1234")
            {
                MessageBox.Show("축하합니다." , textBox1.Text + "님");
                label3.Text = "로그인 성공";
            }
            else
            {
                MessageBox.Show("아이디 및 비밀번호가 다릅니다. 다시 입력해주세요.", "경고");
                label3.Text = "로그인 실패";

            }
            
        }
    }
}
