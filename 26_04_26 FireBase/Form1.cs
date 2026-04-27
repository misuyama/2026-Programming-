using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;  //파이어베이스 추가 명령어
using FireSharp.Interfaces; //파이어베이스 추가 명령어
using FireSharp.Response;  //파이어베이스 추가 명령어

namespace _26_04_26_FireBase
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "TwNFXnj9YSjNRzdnt2cEBNvreNcIOcG8IazA6gBt",
            BasePath = "https://phonebook-faca9-default-rtdb.firebaseio.com/"

        };

        IFirebaseClient Client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 3. 클라이언트 초기화
            Client = new FireSharp.FirebaseClient(config);

            // 4. MessageBox 대소문자 수정 및 if문 괄호 닫기
            if (Client != null)
            {
                MessageBox.Show("client 객체 생성!");
            }

            try //아래를 시도해, 성공했다면 넘어가, 그게 아니라면 catch를 불러
            {
                var r = Client.Set("test", "OK"); //set은 값을 변한다. 테스트라는 로드를 ok라고 로드를 해줘라는 뜻 
                MessageBox.Show("연결 성공!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패!\n" + ex.Message);
            }

        }
    }
}
