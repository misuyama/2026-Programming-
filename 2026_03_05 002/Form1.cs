using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace _2026_03_05_002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //섭씨에서 화씨로 변환한다.
        private void sf_Click(object sender, EventArgs e)
        {
            double fire = double.Parse(textsub.Text); //변수 fire을 textsub안에 있는 문자열을 숫자열로 바꾼다.
            double fire1 = fire * 1.8 + 32;  //fire1은 섭씨에서 화씨로 변환한 값이 들어있는 변수
            textfire.Text = fire1.ToString("F1"); //textsub은 화씨 박스이다. 그래서 즉 textsub안에 fire1(변환한 값이 들어있는 변수)를 문자열로 바꾼 후 출력한다.

            //F1이것은 한 자리까지 표시해라 라는 뜻
        }

        //화씨에서 섭씨로 변환한다.

        private void fs_Click(object sender, EventArgs e)
        {
            double sub = double.Parse(textfire.Text);  //변수 sub는 숫자열이다. textfire 박스는 문자열이다. 즉 같은 계열이 아니므로 바꿔준다.
            double sub1 = (sub - 32) * 5/9; // sub1은 화씨에서 섭씨로 변환한 값이 들어있는 변수이다.
            textsub.Text = sub1.ToString("F1"); //textsub는 섭씨 박스이다. 즉 textsub는 출력을 해야하지만. 숫자열이기에 출력하면 오류가난다. 
            //F1이것은 한 자리까지 표시해라 라는 뜻
        }
    }
}
