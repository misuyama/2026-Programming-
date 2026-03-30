using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _2026_03_29_Chart_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ch1.Titles.Add("성적");

            //ch1.Series.Add("series2"); //디자인 창에서 넣어도 되지만, 소스코드로 추가가 가능하다. 그것을 보여주려고 이렇게 한 것

            //ch1.Series[0].LegendText = "수학"; //디자인 창에서도 추가 가능하다.
            //ch1.Series[1].LegendText = "영어"; //디자인 창에서도 추가 가능하다.

            Random r = new Random(); //Random 객체 r 생성

            for (int i = 1; i < 10; i++)
            {
                ch1.Series[0].Points.AddXY(i, r.Next(101)); //수학점수 , addxy는 xy를 추가하라는 뜻이다. 즉 x에는 i가 들어가고, y에는 r이 들어간다. 
                ch1.Series[1].Points.AddXY(i, r.Next(101)); //영어점수
            }

            onepic.Enabled = false;
        }

        private void ch1_Click(object sender, EventArgs e)
        {

        }

        private void twopic_Click(object sender, EventArgs e)
        {
            if (ch1.ChartAreas.Count >= 2)
            {
                return;
            }
            ch1.ChartAreas.Add("ChartArea2");
            ch1.Series[1].ChartArea = "ChartArea2";

            twopic.Enabled = false;
            onepic.Enabled = true;
        }

        private void onepic_Click(object sender, EventArgs e)
        {

            
                if (ch1.ChartAreas.Count == 1)
                {
                    return;
                }

                ch1.ChartAreas.RemoveAt(1);
                ch1.Series[1].ChartArea = "ChartArea1";

                onepic.Enabled = false;   // 합치면 다시 못 누르게
                twopic.Enabled = true;    // 다시 쪼갤 수 있게
            }
        }

    }

