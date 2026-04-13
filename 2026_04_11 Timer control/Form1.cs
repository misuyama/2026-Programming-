using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_04_11_Timer_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("아날로그 시계는 구현하지 않았습니다.", "알림");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; //추가한 타이머를 활성화시키는 명령어 항상 트루로
            timer1.Interval = 1; // 1000ms = 1s   
            timer1.Tick += timer1_Tick ; //번개모양은 이벤트 tick에서 지정함

            date.Font = new Font("궁서체", 20, FontStyle.Bold);
            date.ForeColor = Color.DarkOrange;
            time.Font = new Font("궁서체", 20, FontStyle.Strikeout);
            time.ForeColor = Color.DarkKhaki;

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 디지털ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("yyyy년 MM월 dd일"); //암기  
            time.Text = DateTime.Now.ToString("tt HH:mm:ss:fffffff"); //시간뒤에 소수점을 나타내려고한다.

            time.Location = new Point(ClientSize.Width / 2 - time.Width / 2, ClientSize.Height / 2 - time.Height / 2 + 30);
            date.Location = new Point(ClientSize.Width / 2 - date.Width / 2, ClientSize.Height / 2 - date.Height / 2 - 30);
        }

        private void 멈추기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else
                timer1.Enabled = true;
        }
    }
}

