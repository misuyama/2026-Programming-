using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_03_14_Messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //MessageBox.Show("안녕하세요.", "이것은 제목입니다.");
           //MessageBox.Show("안녕하세요.", "버튼 추가", MessageBoxButtons.YesNoCancel);
           //MessageBox.Show("안녕하세요.", "버튼 추가", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
           //MessageBox.Show("과연 느낌표는 존재할까요?", "두구두구",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      
            //MessageBox.Show("안녕하세요.", "이것은 제목입니다.");

            DialogResult hooing1 = MessageBox.Show("안녕하세요.","버튼 추가",  MessageBoxButtons.YesNoCancel);

            DialogResult hooing2 = MessageBox.Show("안녕하세요.", "버튼 추가",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            DialogResult hooing3 = MessageBox.Show( "과연 느낌표는 존재할까요?", "두구두구",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            string msg = string.Format("당신의 선택 : {0} {1} {2}",hooing1.ToString(),hooing2.ToString(),hooing3.ToString());
            MessageBox.Show(msg, "Your choice");

            DialogResult result3 = MessageBox.Show(
    "디폴트 버튼을 두 번째 버튼으로 \n     지정한 메시지박스입니다.",
    "Question",
    MessageBoxButtons.YesNoCancel,
    MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button2);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

