using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_23_시험대비_3
{
    //체크박스 배열 cBox를 foreach문으로 순회하여, 체크된 항목의 이름만 골라 summary 문자열에 추가하는 코드를 완성하시오.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string summary = ""; //값 추가하는 문자열
            CheckBox[] cbox = { checkBox1, checkBox2, checkBox3 }; 
            foreach (var item in cbox)
            {
                summary += string.Format("{0} : {1}\n", item.Text, item.Checked);
            }
            MessageBox.Show(summary, "결과");

            string a = string.Format("좋아하는 과일은 :");
            foreach (var item in cbox)
            {
                if (item. Checked == true)
                {
                    a += item.Text + " ";
                }
                
            }
            MessageBox.Show(a, "a");

        }
    }
}
