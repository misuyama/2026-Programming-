using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_23_시험대비_4
{
    //체크박스 배열을 foreach로 두 번 순회하여,
    //첫 번째는 전체 체크 상태를, 두 번째는 체크된 항목 이름만 출력하시오.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string abc = "";
            CheckBox[] cbox = { checkBox1, checkBox2, checkBox3 }; //체크박스를 만들어준다. 
            foreach (var item in cbox) // 체크박스를 이용해 추가하는 반복문이다.
            {
                abc += string.Format("{0} : {1}\n",
                    item.Text, item.Checked);
            }

            MessageBox.Show(abc, "결과");

            string abcd = "좋아하는 과일은 : ";
            foreach (var item in cbox)
            {
                if(item.Checked == true)
                {
                    abcd += item.Text +" ";
                }
            }

            MessageBox.Show(abcd, "abcd");

        }
    }
}
