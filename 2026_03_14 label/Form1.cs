using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_14_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "성 게오르기우스(라틴어: Georgius, 영어: Saint George, 생년 미상 ~ 303년 4월 23일)는 초기 기독교의 순교자이자 14성인 가운데 한 사람이다.";
            label2.Text = "4세기 초에 참수된 게오르기우스에 대한 역사적 사실은 그의 무덤이 있는 이스라엘의 리다에서 발굴한 해석에 바탕을 두고 있다." + 
                "5세기 즈음에 그의 생애에 대한 설명이 처음 등장한다."+
                "게오르기우스의 생애는 확실하지 않으나 전하는 바에 따르면 그는 3세기 후반에 로마 제국의 속주 팔레스티나의 리다에서 크리스트교를 믿는 그리스계 귀족의 가정에서 태어났으며, 로마의 군인이었던 아버지와 마찬가지로 그도 소아시아(오늘날의 튀르키예)의 니코메디아에서 군인으로 복무하였다고 한다."
                + "로마 황제 디오클레티아누스는 302년에 로마 군단 안에서 크리스트교 신자들을 모조리 잡아들여서 로마의 전통 신들을 받들지 않으면 안 된다는 내용의 정령을 내렸고, 게오르기우스도 체포되어 이러한 배교를 강요받았으나 이를 거절하고 순교하였다고 전하고 있다.";
        }
    }
}
