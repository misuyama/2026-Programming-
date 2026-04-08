using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("아날로그 시계는 만들지 않았습니다.", "경고");
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; //추가한 타이머를 활성화시키는 명령어 항상 트루로
            timer1.Interval = 1; // 1000ms = 1s   
            timer1.Tick += Timer1_Tick1; //번개모양은 이벤트 tick에서 지정함

            lbldate.Font = new Font("궁서체", 20, FontStyle.Bold);
            lbldate.ForeColor = Color.DarkOrange;
            lbltime.Font = new Font("궁서체", 20, FontStyle.Strikeout);
            lbltime.ForeColor = Color.DarkKhaki;



        }

        private void Timer1_Tick1(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일"); //암기  
            lbltime.Text = DateTime.Now.ToString("tt HH:mm:ss:fffffff"); //시간뒤에 소수점을 나타내려고한다.

            lbltime.Location = new Point(ClientSize.Width/2 - lbltime.Width/2, ClientSize.Height/2 - lbltime.Height/2 + 30);
            lbldate.Location = new Point(ClientSize.Width / 2 - lbldate.Width / 2, ClientSize.Height / 2 - lbldate.Height / 2 - 30);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void 정지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else
                timer1.Enabled = true;
        }




                private void 표시형식ToolStripMenuItem_Click(object sender, EventArgs e)
                {

                }
    }
}
