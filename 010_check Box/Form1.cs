using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_check_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //체크박스는 배열을 만들어서 사용한다. 
            //하나, 둘, 셋, 넷을 배열을 만들어서 사용한다.
            //CheckBox[ ] cbox ={check box 1, check box 2, check box 3....};
            //foreach (var x in cbox) 배열에 있는 각각에  x에 대해서 for는 뭐뭐에 대해서, cbox안에 있는 것을 반복한다.
            //각각에 x.text나 x.checked가 있는것이다. 
            string checkStates = "";
            CheckBox[] cBox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };
            foreach (var item in cBox)
            {
                checkStates += string.Format("{0} : {1}\n",
                    item.Text, item.Checked);

            }
            MessageBox.Show(checkStates, "checkStates");

            string summary = string.Format("좋아하는 병과는 : ");
            foreach (var item in cBox)
            {
                if (item.Checked == true)
                    summary += item.Text + "  ";

            }
            MessageBox.Show(summary, "Summary");
        }
    }
}
