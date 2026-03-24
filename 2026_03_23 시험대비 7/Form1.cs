using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_23_시험대비_7
{

    public partial class Form1 : Form
    {
        private RadioButton a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = "";

            if (rbMale.Checked == true)
            {
                b += "남자입니다.\n";
            }

            else if (rbFemale.Checked == true)
            {
                b += "여자입니다.\n";
            }




            string c = "좋아하는 과일은 :";
            CheckBox[] cbox = { checkBox1, checkBox2, checkBox3 };
            foreach (var item in cbox)
            {
                if (item.Checked == true)
                {
                    c += string.Format("{0}", item.Text + " ");
                }
            }

            MessageBox.Show(b + c);



        }

        

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            a = rbMale;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            a = rbFemale;
        }
    }
}
