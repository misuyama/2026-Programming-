using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005___login
{
    public partial class sad1 : Form
    {
        public sad1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void on_Click(object sender, EventArgs e)
        {



            if (textBox1.Text == "abcd"  && textBox2.Text =="1234") {
                result.Text = "로그인 되었습니다. 축하합니다.";
            }
            else 
            {
                result.Text = "로그인 안됩니다. 돌아가세요.";
            }
                
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
