using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_14_Textbox__label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ""; //label1을 초기화해준다. 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="") // 만약 텍스트 박스 내에 아무것도 입력하지 않았다면 이름을 입력받는 메세지 박스가 나온다.

            {
               MessageBox.Show("이름 입력해주세요 :", "이름 적어주세요."); //처음에 있는 것은 메세지 박스에 뜨는것, 두번째 있는 것은 메세지 박스에 뜨는 제목이라고 할 수 있다.
            }
            else
            {
                label1.Text = textBox1.Text + "님 어서오세요.";
                MessageBox.Show(textBox1.Text + "님 어서오세요.", "축하합니다~");
            }
        }
    }
}
