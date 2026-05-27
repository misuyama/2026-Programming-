using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _036_WPFClock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private Transform hrt;

        public MainWindow()
        {
            InitializeComponent();

            this.Height += SystemParameters.WindowCaptionButtonHeight;
            drawface();
            makeclockHands();

            //타이머 세팅
            DispatcherTimer dt = new DispatcherTimer();
            //dt.Interval = new TimeSpan(0, 0, 0, 0, 10); //10ms
            dt.Interval = new TimeSpan(0, 0, 0,0,1); //1초
            dt.Tick += Dt_tick;
            dt.Start();
        }

        private void makeclockHands()
        {
    


            //자멜에서 만들지 않고 여기서 만들어도 된다.
            /*
            Line sechand = new Line();
            sechand.Stroke = Brushes.Red;
            sechand.StrokeThickness = 2;
            sechand.StrokeEndLineCap = PenLineCap.Round;
            */

            int w = 300;
            secHand.X1 = w / 2;
            secHand.Y1 = w / 2 + 10;
            secHand.X2 = w / 2;
            secHand.Y2 = 20;

            minHand.X1 = w / 2;
            minHand.Y1 = w / 2;
            minHand.X2 = w / 2;
            minHand.Y2 = 40;

            hourHand.X1 = w / 2;
            hourHand.Y1 = w / 2;
            hourHand.X2 = w / 2;
            hourHand.Y2 = 60;

            }


        private void drawface()
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
                RotateTransform rt = new RotateTransform(6 * i); //하나 당 6도 씩 회전을 하게 된다.
                rt.CenterX = 150;  //회전의 중심
                rt.CenterY = 150;
                marking[i].RenderTransform = rt; // 랜덤한 것을 할당을 하게 해준다. marking[i]가 그 뜻이다.  왜? 
                aClock.Children.Add(marking[i]);
            }
        }
            



        private void Dt_tick(object sender, EventArgs e) //여기부분 중요해보임 ㅇㅇ
        {
        DateTime dt = DateTime.Now; //현재 시간을 가져와서 시, 분, 초로 만든다. 

            int h = dt.Hour;  //시간
            int m = dt.Minute;   //분
            int s = dt.Second;   // 초
            int mil = dt.Millisecond;


            double hDeg = h % 12 * 30 + m * 0.5;
            double mDeg = m * 6 + s * 0.1;
            double sDeg = s * 6 + mil * 0.006; // 1000ms - > 6도

            int w = 300;

            aClock.Children.Remove(hourHand);
            RotateTransform hrt = new RotateTransform(hDeg);
            hrt.CenterX = w / 2;
            hrt.CenterY = w / 2;
            hourHand.RenderTransform = hrt;
            aClock.Children.Add(hourHand);

            aClock.Children.Remove(minHand);
            RotateTransform mrt = new RotateTransform(mDeg);
            mrt.CenterX = w / 2;
            mrt.CenterY = w / 2;
            minHand.RenderTransform = mrt;
            aClock.Children.Add(minHand);


           //aClock.Children.Remove(secHand);
           //RotateTransform srt = new RotateTransform(sDeg);
           //srt.CenterX = w / 2;
           //srt.CenterY = w / 2;
           //secHand.RenderTransform = srt;
           //aClock.Children.Add(secHand);

            aClock.Children.Remove(secHand); 
            RotateTransform srt = new RotateTransform(sDeg);
            srt.CenterX = w / 2;
            srt.CenterY = w / 2;
            secHand.RenderTransform = srt; 
            aClock.Children.Add(secHand);

            aClock.Children.Remove(center);
            aClock.Children.Add(center);






        }
    }
}
