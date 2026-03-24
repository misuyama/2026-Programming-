using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_03_25
{
    public partial class Form1 : Form
    {
        private RadioButton q;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string r = "";
            string w = "";
            string t = "";
            double a = double.Parse(textBox1.Text) + Convert.ToDouble(textBox2.Text);
            double sum = a / 2;

            CheckBox[] cbox = {checkBox1, checkBox2};
            foreach(var item in cbox)
            {
                if (item.Checked == true)
                {
                    t += item.Text;
                }
            }

            if (radioButton1.Checked)
            {
                w += "남자요";
            }
            else if (radioButton2.Checked)
            {
                w += "여자요";
            }

            r = string.Format("국적은 {0} 이고\n 좋아하는 과목은 : {1}\n, 점수 합계는 {2}, 평균은 {3}이다.", w, t, a,sum);
            MessageBox.Show(r);
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            q = radioButton1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            q = radioButton2;
        }
    }
}
