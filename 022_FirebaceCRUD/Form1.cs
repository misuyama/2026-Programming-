using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace _022_FirebaceCRUD
{
    public partial class Form1 : Form
    {
        // 1. 쉼표(,) 추가 및 중괄호 정리
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "TwNFXnj9YSjNRzdnt2cEBNvreNcIOcG8IazA6gBt",
            BasePath = "https://phonebook-faca9-default-rtdb.firebaseio.com/"
        };

        // 2. Client는 'Config'가 아니라 'Client' 인터페이스여야 합니다.
        IFirebaseClient Client;

        public Form1()
        {
            InitializeComponent();

            // 3. 클라이언트 초기화
            Client = new FireSharp.FirebaseClient(config);

            // 4. MessageBox 대소문자 수정 및 if문 괄호 닫기
            if (Client != null)
            {
                MessageBox.Show("Connection 성공");
            }
        } // Form1 생성자 닫기

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}