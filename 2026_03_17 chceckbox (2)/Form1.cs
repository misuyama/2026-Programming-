using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_17_chceckbox__2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "";
            CheckBox[] cbox = { checkBox1, checkBox2, checkBox3 };
            foreach (var item in cbox)
            {
                a += string.Format("{0) : {1}",
                    item.Text, item.Checked);
            }



        }
    }
}
