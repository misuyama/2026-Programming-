using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_24
{
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
            // if (textBox1.Text == "abcd" && textBox2.Text == "1234")
            // {
            //     label3.Text = "로그인 성공";
            // }
            // else
            // {
            //     label3.Text = "로그인 실패";
            // }



            DialogResult a = MessageBox.Show("안녕", "응", MessageBoxButtons.OKCancel);
            DialogResult b = MessageBox.Show("느금", "어쩌라고", MessageBoxButtons.YesNo);
            DialogResult c = MessageBox.Show("뭐 어쩌라고요", "보댕이", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            string n = string.Format("{0} , {1} , {2}", a, b, c);
            MessageBox.Show(n);
        }
    }
}
