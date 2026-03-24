using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_23_시험대비_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string kim = "김태우";
            //double nai = 20;
            //
            //
            //string rufrhk = string.Format("이름은 {0}, 나이는 {1}", kim, nai);
            //MessageBox.Show(rufrhk, "결론은");
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "";
            CheckBox[] cbox = { checkBox1, checkBox2, checkBox3 };
            foreach (var item in cbox)
            {
                a += string.Format("{0} : {1}\n", item.Text, item.Checked);
            }
            MessageBox.Show(a);

            string b = "좋아하는 과일은 :";
            foreach (var item in cbox)
            {
                if(item.Checked == true)
                {
                    b += item.Text + " ";
                }
            }
            MessageBox.Show(b);
        }
    }
}
