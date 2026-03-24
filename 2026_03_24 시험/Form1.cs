using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_24_시험
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "abcd" && txtpw.Text == "1234")
            {
                DialogResult a = MessageBox.Show("계속 진행하시겠습니까?", "로그인 성공", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    MessageBox.Show("환영합니다.", "로그인 성공");
                }
                else
                {
                    MessageBox.Show("다음에 만나요.");
                }
            }
            else
            {
                MessageBox.Show("로그인 실패", "로그인 실패");
            }
        }
    }
}
