using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_24_checkbox
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
         
            string a = "";
            CheckBox[] cbox = { checkBox1, checkBox2, checkBox3 };
            foreach(var item in cbox) { //선택 or 비선택 
                a += string.Format("{0} : {1}\n", item.Text, item.Checked);
            
            }
            MessageBox.Show(a, "선택의 결과는?");

            string b = "좋아하는 과일은? ";
            foreach(var item in cbox)
            {
                if(item.Checked == true)
                {
                    b += item.Text + " ";
                }
            }

            MessageBox.Show(b, "좋아하는 과일은?");

        }
    }
}
