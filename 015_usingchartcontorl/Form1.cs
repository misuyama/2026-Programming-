using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //인클루드하는 것 처럼 사용한다.
using System.Windows.Forms.DataVisualization.Charting; //암기할수는 없다. 너무 길다.(?)

namespace _015_usingchartcontorl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //x축 설정을 한다. 
            chart1.ChartAreas[0].AxisX.Minimum = -20; //최소값
            chart1.ChartAreas[0].AxisX.Maximum = 20; //최대값
            chart1.ChartAreas[0].AxisX.Interval = 0.5; 
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            //y축 설정을 한다. 
            chart1.ChartAreas[0].AxisY.Minimum = -2; //최소값
            chart1.ChartAreas[0].AxisY.Maximum = 2; //최대값
            chart1.ChartAreas[0].AxisY.Interval = 2;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            //Series[0] : sin(x) / x
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.LightGreen;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].LegendText = "sin(x) /x"; //범례이다.

            //Series[1] : cos(x) / x
            chart1.Series.Add("cos  "); //이것은 명령어로 추가 가능 or 직접 도구상자에서 추가할 수 있다. 
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.Orange;
            chart1.Series[0].BorderWidth = 2; 
            chart1.Series[0].LegendText = "cos(x) /x"; //범례이다.

            for (double x = -20; x <= 20; x += 0.1)
            {
                double y = Math.Sin(x) / x;
                chart1.Series[0].Points.AddXY(x, y);

                y = Math.Cos(x) / x;
                chart1.Series[1].Points.AddXY(x, y);
            }
            chart1.ChartAreas[0].BackColor = Color.DarkBlue;


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
