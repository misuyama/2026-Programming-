using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("성적");

            chart1.Series[0].Points.Add(123); //0는 들어가있는 데이터이다.
            chart1.Series[0].Points.Add(231);
            chart1.Series[0].Points.Add(823);
            chart1.Series[0].Points.Add(531);
            chart1.Series[0].Points.Add(731);
            for (int i = 0; i < 5; i++)
                chart1.Series[0].Points.Add((i+1) * 100);

        }

    }
}
