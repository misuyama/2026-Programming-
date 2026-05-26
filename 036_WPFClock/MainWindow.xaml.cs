using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _036_WPFClock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            drawface();
            makeclockHands();

            //타이머 세팅
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 0, 10); //10ms
            dt.Tick += Dt_tick;
            dt.Start();
        }

        private void makeclockHands()
        {
            //눈금 60개를 만든다 .
            Line[] marking = new Line[60];
            int w = 300; //시계의 폭(지름)

            for (int i = 0; i < 60; i++)
            {
                marking[i] = new Line();
                marking[i].Stroke = Brushes.LightGoldenrodYellow;
                marking[i].X1 = w / 2;
                marking[i].Y1 = 2;
                marking[i].X2 = w / 2;
                if (i % 5 == 0) // 5번째 눈금마다
                {
                    marking[i].StrokeThickness = 5;
                    marking[i].Y2 = 20;
                }
                else
                {
                    marking[i].StrokeThickness = 2;
                    marking[i].Y2 = 10;
                }

                //눈금 하나당 중심점을 기준으로 6도씩 회전
                RotateTransform rt = new RotateTransform(6 * i);
                rt.CenterX = 150;  //회전의 중심
                rt.CenterY = 150;
                marking[i].RenderTransform = rt;
                aClock.Children.Add(marking[i]);
            }
        }

        private void drawface()
        {
        
        }

        private void Dt_tick(object sender, EventArgs e)
        {
        
        }
    }
}
