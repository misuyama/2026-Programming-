using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_bmi_restart
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
            double high = double.Parse(txthigh.Text);
            double muge = double.Parse(txtweight.Text);

            double highh = high/100;
            double sum = muge/ (highh * highh);
            //result.Text = sum.ToString();

            //1자리까지만 나타낸다.
            result.Text = string.Format("{0:F1}", sum);

            //picturebox 가 추가되었다. bmi 별로 색을 다르게 나타낸다.

            if (sum < 20) {
                result1.Text = ("저체중");
                pictureBox1.BackColor = Color.White;
            }

            else if (20 <= sum) {
                result1.Text = ("정상 체중");
                pi

            }
            else if (sum < 25){ 
                result1.Text = ("정상체중");
            }
            else if (25 <= sum) {
                result1.Text = ("경도비만");
            }
            else if (30 < sum) {
                result1.Text = ("경도비만");
            }
            else if (30 <= sum) {
                result1.Text = ("비만");
            }
            else if (sum < 40) {
                result1.Text = ("비만");

            }
            else  {
                result1.Text = ("고도비만");
            }
                    

           
        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
