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
using System.Xml.Linq;


namespace _035_WPFCalc
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private double saved = 0;
        private string op = "";
        private bool opFlag = false; // true 일 때 숫자 새로쓰기 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

     

        private void btn1_Click(object sender, RoutedEventArgs e) //object 최고 조상
        {
            //Button btn = (Button)sender;
            Button btn = sender as Button;
            if (txtResult.Text == "0" || opFlag == true)
            {   //0일때는 1로 바꾸고
                txtResult.Text = btn.Content.ToString();
                opFlag = false;
            }
            else
                txtResult.Text += (string)btn.Content; //1일때는 1을 뒤에 추가로 더한다.   //txtResult.Text = btn.Content as string;
                                                                                   
           
                                                                                                        
        }
        //소수점 
        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.Contains(".") == false)
                //(!txtResult.Text.Contains("."))
                txtResult.Text += ".";

        }
        //+/-
        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            //같은 방법 txtResult.Text = (-double.Parse(txtResult.Text)).ToString();
            double x = double.Parse(txtResult.Text);
            x = -x;
            txtResult.Text = x.ToString();

             
        }
        //4개 연산자 처리 함수
        private void btnPlue_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button) sender;


            //(1) 현재 결과창의 값을 숫자로 저장
           saved =  double.Parse(txtResult.Text);


            // (2) 연산자를 저장
            op = btn.Content.ToString();


            // (3) opFlag 설정
            opFlag = true;


            txtEXP.Text = txtResult.Text + op;

            
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            txtEXP.Text += txtResult.Text + "=";

            switch (op)
            {
                case "+":
                    txtResult.Text = (saved + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (saved - double.Parse(txtResult.Text)).ToString();
                    break;
                case "×":
                    txtResult.Text = (saved * double.Parse(txtResult.Text)).ToString();
                    break;
                case "÷":
                    txtResult.Text = (saved / double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;

            }
        }

        private void btnEqual_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            // ²√x 수식창 처리
            if (txtEXP.Text == "")
                txtEXP.Text = "²√(" + txtResult.Text + ")";  //비어있을 때는 루트를 씌우고
            else 
                txtEXP.Text = "²√(" + txtEXP.Text + ")"; // 비어있지 않으면 exp를 씌우고

            //결과창 처리
            txtResult.Text = Math.Sqrt(double.Parse(txtResult.Text)).ToString();
        }

        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            // x² 수식창 처리
            if (txtEXP.Text == "")
                txtEXP.Text = "sqr(" + txtResult.Text + ")";  //비어있을 때는 루트를 씌우고
            else
                txtEXP.Text = "sqr(" + txtEXP.Text + ")"; // 비어있지 않으면 exp를 씌우고

            //결과창 처리
            double x = double.Parse(txtResult.Text);
            txtResult.Text = (x * x).ToString();
        }

        private void btnRecip_Click(object sender, RoutedEventArgs e)
        {
            // x수식창 처리
            if (txtEXP.Text == "")
                txtEXP.Text = "1/(" + txtResult.Text + ")";  //비어있을 때는 루트를 씌우고
            else
                txtEXP.Text = "1/(" + txtEXP.Text + ")"; // 비어있지 않으면 exp를 씌우고

            //결과창 처리
            double x = double.Parse(txtResult.Text);
            txtResult.Text = (1/x).ToString();
        }
    }
}
