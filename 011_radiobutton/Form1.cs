using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_radiobutton
{


    
    public partial class Form1 : Form
    {
        private RadioButton checkedRB;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //라디오 버튼은 하나만 선택할 때 사용된다.
            //ex) 넷중의 하나만 쓸 때 사용한다. 
            //private RadioButton.checkRB;
            //남자가 확인되면  rbmale가 사용되고, 여성이 사용되면 rbfemal이 사용된다.
            //if문 가지고 사용하거나, foreach로 사용한다.

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = radioButton5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = ""; //string 타입에 변수 result를 선언한것이다. 
            if (radioButton1.Checked)
            {
                result += "국적 : 한국/n";

            }
            else if (radioButton2.Checked)
            {
                result += "국적 : 몽골/n";
            }
            else if (radioButton3.Checked)
            {
                result += "국적 : 베트남/n";
            }
            else if (radioButton4.Checked)
            {
                result += "국적 : 인도세시아/n";
            }

            if (checkedRB == radioButton5)
            {
                result += "성별 남성";
            }
            else if (checkedRB == radioButton6)
            {
                result += "성별 : 여성";
            }

                MessageBox.Show(result, "Result");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = radioButton6;
        }
    }
}
