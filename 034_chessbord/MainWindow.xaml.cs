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

namespace _034_chessbord
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() //생성자 메소드
        {
            InitializeComponent(); //비주얼스튜디오가 필요한 작업을 하는 메소드

            chessboard.Rows = 8;
            chessboard.Columns = 8;

            for(int i = 0; i < 64/2; i++)
            {
                Rectangle r = new Rectangle();
                r.Fill = Brushes.Black;
                r.Margin = new Thickness(1);

                Rectangle r1 = new Rectangle();
                r1.Fill = Brushes.Red;
                r1.Margin = new Thickness(1);

                if((i / 4)%2 ==0)
                {
                    chessboard.Children.Add(r);
                    chessboard.Children.Add(r1);
                }
             else
                {
                    chessboard.Children.Add(r1);
                    chessboard.Children.Add(r);
                }
            }
        }
    }
}
