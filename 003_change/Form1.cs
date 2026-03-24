using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_change
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        //섭씨 -> 화씨
        private void button1_Click(object sender, EventArgs e) //섭씨에서 화씨로 변환
        {
          
            double fire = double.Parse(firebox.Text);
            double fire1 = (fire - 32) * 5 / 9;
            subbox.Text = fire1.ToString("F1");
            //F1이것은 한 자리까지 표시해라 라는 뜻

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //화씨 -> 섭씨
        private void button2_Click(object sender, EventArgs e) //화씨에서 섭씨로 변환
        {
            double sub = double.Parse(subbox.Text);
            double sub1 = sub * 9 / 5 + 32;
            firebox.Text = sub1.ToString("F1"); 

            //F1이것은 한 자리까지 표시해라 라는 뜻
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void firebox_TextChanged(object sender, EventArgs e)
        {
           


        }
    }
}
