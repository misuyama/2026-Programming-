using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_17_복습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(namebox.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요 : ", "이름 입력");
            }

            else
            {
                hide.Text = namebox.Text + "님 어서오세요!";
            }
        }
    }
}
