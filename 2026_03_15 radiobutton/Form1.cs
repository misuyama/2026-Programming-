using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_15_radiobutton
{
    public partial class Form1 : Form
    {
        private RadioButton checkedRB;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string munja = "";
            if (kr.Checked)
            {
                munja += "국적 : 대한민국\n";
            }
            else if (ch.Checked)
            {
                munja += "국적 : 중국\n";
            }
            else if (usa.Checked)
            {
                munja += "국적 : 미국\n";
            }
            else if (ind.Checked)
            {
                munja += "국적 : 인도\n";
            }
            if (checkedRB == male)
            {
                munja += "성별 : 남성";
            }

            else if (checkedRB == her)
            {
                munja += "성별 : 여성";
            }

            MessageBox.Show(munja, "결과");

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = male;
        }

        private void her_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = her;
        }
    }
}
