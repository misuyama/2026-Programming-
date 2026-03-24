using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_24_시험_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = "";
            string a = "";
            int count = 0;
            CheckBox[] cbox = { checkBox1, checkBox2 };
            foreach (var item in cbox)
            {
                if (item.Checked == true)
                {
                    count++;
                    a += item.Text + "";
                }



            }

            string b = string.Format("선택한 과일은{0} 총 과일 개수는 {1} 이다.", a, count);
            MessageBox.Show(b);


        }
    }
}
