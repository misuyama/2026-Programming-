using System;
using System.Windows;
using System.Windows.Controls;

//진한건 쓴거, 흐른건 사용하지 않은 것 우클릭 -> USING 제거 및 정렬 클릭

namespace _035_WPFCalc
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private double saved = 0;
        private string op = "";  // op 문자열이기에 초기화
        private bool opFlag = false; // true 일 때 숫자 새로쓰기 
        private double memory = 0;
        private bool memoryFlag = false; //memory 버튼이 눌린 후 true 왜냐? 값이 들어가있기에 메모리에 저장할 수 있기 때문이다. (숫자 새로 쓴다)

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e) //object 최고 조상 
 //Sender가 3번이든 4번이든 버튼을 눌렸다면, 일단 그 정보를 object로 보내준다.  이제 그 정보를 버튼으로 받아서 사용하겠다는 의미가 된다. 그 명령어가   Button btn = sender as Button; 이다.
//  btn.Content.ToString(); 여기 컨텐더가 오브젝트이다. 이 오브젝트에는 무엇이 들어갈 지 모른다. ex) 그림판, 사진 등등 그렇기 때문에 문자열로 바꿔주는 과정이 필요하다. ToStirng()이다. 
        {

            //그냥 이 부분 시험임 ㅇㅇ

            //Button btn = (Button)sender;
            Button btn = sender as Button;  //이 명령어가 정보를 버튼으로 받아서 사용하는 것이다. 이제 sender에 뭐든 숫자가 들어가든지 버튼을 받아서 쓸거다. 기억해라 ㅇㅇ 
            if (txtResult.Text == "0" || opFlag == true || memoryFlag == true)  //0일 때, opflag 가 트루일 때, 메모리 값이 사실일 때
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

        //현재 txtResult 창만 0으로 만들기
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0"; 
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
            txtEXP.Text = "";
            saved = 0;
            op = ""; //strig.Empty 같은 뜻이다.
            opFlag = false;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1); //시험문제 
            if (txtResult.Text == "");
            txtResult.Text = "0";
           //string s = txtResult.Text;
           //s=s.Remove(s.Length  - 1);
           //if (s == "")
           //    s = "0";
           //txtResult.Text = s;
            
        }

        private void btnMS_Click(object sender, RoutedEventArgs e)
        {
            memory = double.Parse(txtResult.Text);
            btnMS.IsEnabled = true;
            btnMR.IsEnabled = true;
            memoryFlag = true;
        }

        //메모리 리드 : 값을 가져온다.
        private void btnMR_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = memory.ToString();
            memoryFlag = true;

        }

        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
            memoryFlag = true;
            btnMC.IsEnabled = false;
            btnMR.IsEnabled= false;
        }

        private void btnMPlus_Click(object sender, RoutedEventArgs e)
        {
            memory += double.Parse(txtResult.Text);
            memoryFlag = true;
        }

        private void btnMMinus_Click(object sender, RoutedEventArgs e)
        {
            memory -= double.Parse(txtResult.Text);
            memoryFlag = true;
        }
    }
}
