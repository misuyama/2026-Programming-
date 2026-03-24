using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_15_checkbox_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string abc = ""; //abc 이름을 가진 문자열을 선언한다.
            CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4 };

            foreach (var item in cBox)
            {
                abc += string.Format("{0} : {1}\n", item.Text, item.Checked);

            }
            MessageBox.Show(abc, "선택한 것 확인");

            string sum = string.Format("좋아하는 계절은 : ");
            foreach (var item in cBox)
            {
                if (item.Checked == true)
                {
                    sum += item.Text + " ";
                }

            


            }
            MessageBox.Show(sum, "결론은 ");
        }
    }
}


