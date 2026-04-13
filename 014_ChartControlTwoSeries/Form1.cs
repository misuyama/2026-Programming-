using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_171chart1
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

            chart1.Series.Add("series2"); //디자인 창에서 넣어도 되지만, 소스코드로 추가가 가능하다. 그것을 보여주려고 이렇게 한 것

            chart1.Series[0].LegendText = "수학";
            chart1.Series[1].LegendText = "영어";

            Random r = new Random(); //Random 객체 r 생성

            for( int i = 1; i < 10; i++)
            {
                chart1.Series[0].Points.AddXY(i, r.Next(101)); //수학점수 , addxy는 xy를 추가하라는 뜻이다. 즉 x에는 i가 들어가고, y에는 r이 들어간다. 
                chart1.Series[1].Points.AddXY(i, r.Next(101)); //영어점수
            }

            btnOneChartArea.Enabled = false; //시작했을 때 합쳐서 그리는 버튼을 아에 비활성화를 시켜버린다.
        }

        private void BtnTwoChartArea_Click(object sender, EventArgs e)
        {
            if (chart1.ChartAreas.Count >= 2)
            {
                return;
            }
            chart1.ChartAreas.Add("ChartArea2");
            chart1.Series[1].ChartArea = "ChartArea2";

            BtnTwoChartArea.Enabled = false;
            btnOneChartArea.Enabled = true;

        }

        private void btnOneChartArea_Click(object sender, EventArgs e)
        {
            if (chart1.ChartAreas.Count == 1) //이러한 코드를 입력하면 코드가 꺼지지 않는다.
            {
                return;
            }
            chart1.ChartAreas.RemoveAt(1); //두번째 ChartArea 삭제
            chart1.Series[1].ChartArea = "ChartArea1"; //ChartArea1의 스펠링을 잘 확인해야한다. 스펠링이 틀렸을 경우 제대로 입력되지 않는다.

            BtnTwoChartArea.Enabled = true;
            btnOneChartArea.Enabled = false;

        }
    }
}
