using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
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

namespace _037_Maching_Game
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int[] rnd = new int[16]; // 이미 한번 나온건지 확인하는 배열
        Button first = null;
        Button second = null;
        int matched = 0;
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow() // 생성자메소드
        {
            InitializeComponent();

            boardSet();

            //timer 세팅
            timer.Interval = new TimeSpan(0, 0, 0, 0, 750);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            first.Content = MakeImage("../../Images/check.png");
            second.Content = MakeImage("../../Images/check.png");
            first = null;
            second = null;
        }


        // 게임판 만들기
        private void boardSet()
        {  //시험예상 자세히 설명하심 
           for(int i = 0; i < 16; i++)
            {
                Button b = new Button();
                b.Background = Brushes.White;
                b.Margin = new Thickness(10); // 너무 붙어있으니까 떨어트려진다. 
                //b.Content = i;
                b.Content = MakeImage("../../Images/check.png");
                b.Tag = TagSet();  //제일 중요한 부분이다. Tag부분이 중요함
                                   // 테스트 용  b.Content = b.Tag;
                b.Click += B_Click;
                board.Children.Add(b);
            }
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button; // (button)sender

            string[] icon = { "딸기", "레몬", "모과", "배", "사과", "수박", "파인애플", "포도" };

            btn.Content = MakeImage("../../Images/" + icon[(int)btn.Tag] + ".png");

            if (first == null)  //this button is first button  
            {
                first = btn;
                return;
            }

            second = btn;

            if ((int)first.Tag == (int)second.Tag) //matched
            {
                first = null;
                second = null;
                matched += 2;

                if (matched == 16)
                {
                    MessageBox.Show("게임이 끝났습니다!", "Success!");
                    MessageBox.Show("고생하셨습니다.", "빰빠라라빰");
                    this.Close();
                }
                
                     else
            {
                timer.Start();
            }
            }
            else
            {
                timer.Start();
            }
        }


        //과일을 의미하는 0~7사이의 정수를 리턴한다.
        //다른 의미로는 시험나온다.
        private int TagSet()
        {
           
            int i;
            Random r= new Random();

            while (true)
            {
                i=r.Next(16); // 0~15
                if (rnd[i] == 0) // i가 처음 나왔다면 
                {
                    rnd[i] = 1;
                    break;
                }
            }
            return i % 8;
        }

        private Image MakeImage(string v)
        {
            //WPF에서 이미지 만드는 방법
            BitmapImage bi = new BitmapImage();
            bi.BeginInit(); 
            bi.UriSource = new Uri(v, UriKind.Relative); //../../Images/check.png 주소값이다. 
            bi.EndInit();

            Image img = new Image();
            img.Margin = new Thickness(10);
            img.Stretch = Stretch.Fill;
            img.Source = bi;

            return img;

            //컨트롤들에는 Tag가 숨어있다. 오브젝트이기에 어떤 값도 올 수 있다. 저것을 보고 5가 있으면 5번째 수박 이미지가 있으면 수박 이미지를 보여준다. 

        }
    }
}
