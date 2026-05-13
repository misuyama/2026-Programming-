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

namespace _030_Language
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //투표하기 버튼 클릭 이벤트 처리
        //기말고사예상됨 그냥 중간고사때 나왔던거임 ㅇㅇ
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = "";

            // 중간고사때 문제가 나왔음
            CheckBox[] cbs = { cbc, cbcpp, cbss, cbpy, cbja, cbj};
            foreach(var item in cbs)
            {
                if (item.IsChecked == true)
                    s += item.Content + "  ";
            }

            s += "선택된 결과";

            MessageBox.Show(s, "좋아하는 언어입니다.");
        }

        private void btnend_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
