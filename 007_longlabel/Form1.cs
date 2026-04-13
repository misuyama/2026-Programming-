using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_longlabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            title.Text = "";
            longlabel.Text = "";

            title.Text = "잔 다르크(프랑스어: Jeanne d'Arc, 문화어: 쟝느 다르크, 1412년 1월 6일 ~ 1431년 5월 30일)는 백년 전쟁에서 활약한 프랑스의 수호성인이다. 오를레앙의 처녀(la Pucelle d’Orléans)라고도 불린다.";
            longlabel.Text = "영국과 프랑스 간의 백년 전쟁이 진행 중이던 1412년 프랑스 북동부 지방 동레미에서 농부의 딸로 태어났다.\n " +
                              "프랑스를 구하라는 천사의 계시를 받았다며 1429년 샤를 7세를 찾아가 신뢰를 얻고 백년 전쟁에 참전하였다. \n" +
                             "이후 오를레앙 포위전을 비롯한 여러 전투에서 용감하게 앞장서서 병사들의 사기를 북돋아 프랑스군의 승리를 이끌었고, 이로써 샤를 7세는 랭스 대성당에서 프랑스 국왕으로서의 대관식을 치를 수 있게 되었다.\n" +
                           "하지만 1430년 5월경 부르고뉴 군대에 사로잡힌 후 잉글랜드에 넘겨졌다. 잉글랜드는 종교 재판을 통하여 잔 다르크에게 반역과 이단 혐의를 씌운 후에 화형에 처하였다.\n" +
                           "당시 그녀의 나이는 20세(만 19세)였다.";

        }
    }
}
