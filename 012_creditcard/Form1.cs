using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_18_creditcard
{
    public partial class form1 : Form
    {
        TextBox[] titles; //먼저 선언해준다.
        ComboBox[] crds; //먼저 선언하면 나중에 다시 쓸 필요가 없다.
        ComboBox[] grds; //먼저 선언해준다. 

        public form1()
        {
            InitializeComponent();
        }

        private void btncla_Click(object sender, EventArgs e)
        {

        }


        //Form1이 로드될 때(프로그램이 시작될 때)
        private void form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "비주얼 프로그래밍";
            txt2.Text = "인체 구조와 기능";
            txt3.Text = "설계 및 프로젝트";
            txt4.Text = "전기전자회로 및 실험";
            txt5.Text = "한국근현대사";
            txt6.Text = "역사와 영화";
            txt7.Text = "기업가정신";

            crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7 };
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };
            titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };

            int[] arrCredets = { 1, 2, 3, 4, 5 };
            List<string> lstGrade = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };

            //이중반복문으로 crd1, crd2,....crd7에 1,2,3,4,5를 실행한다.
          // foreach(var combo in crds)
          // {
          //     foreach (var i in arrCredets)
          //         combo.Items.Add(i);
          //     combo.SelectedItem = 2; //2학점을 디폴트로 설정
          // }
          
            foreach(var combo in crds)
            {
                for (int i = 1; i <= 5; i++)
                    combo.Items.Add(i);
                combo.SelectedItem = 2;
            }

            //성적 콤보박스에  A+ 부터 F까지를 등록
            foreach(var combo in grds)
            {
                foreach(var gr in lstGrade)
                    combo.Items.Add(gr);  // 디폴트 지정 x
                combo.SelectedItem = "B+";
            }
        }

        private void btncla_Click_1(object sender, EventArgs e)
        {
            double totalScore = 0; //토탈 점수(학점수 * 성적)
            int totalCredits = 0; //토탈 학점수 
            
            for(int i = 0; i<titles.Length; i++)
            {
                if (titles[i].Text != "") ;
                {
                    // int crd = int.Parse(crds[i].SelectedItem.ToString()); 
                    int crd = int.Parse(crds[i].Text);   //두개가 같다. 
                    totalCredits += crd;
                    totalScore += crd * GetGrade(grds[i].Text);
                }

            }
            txtgraed.Text = (totalScore / totalCredits).ToString("0.00");
        }

        private double GetGrade(string text)
        {
            if (text == "A+")
                return 4.5;
            else if (text == "A0") 
                return 4.0;
            else if (text == "B+")
                return 3.5;
            else if (text == "B0")
                return 3.0;
            else if (text == "C+")
                return 2.5;
            else if (text == "C0")
                return 2.0;
            else if (text == "D+")
                return 1.5;
            else if (text == "D0")
                return 1.0;
            else return 0.0;  // F 또는 기타

        }
    }
}
