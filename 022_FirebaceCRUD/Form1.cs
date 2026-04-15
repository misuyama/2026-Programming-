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

namespace _022_FirebaceCRUD
{
    public partial class Form1 : Form  
    {
        // 1. 쉼표(,) 추가 및 중괄호 정리
        IFirebaseConfig config = new FirebaseConfig //config 하나 만든다.
        {
            AuthSecret = "TwNFXnj9YSjNRzdnt2cEBNvreNcIOcG8IazA6gBt",
            BasePath = "https://phonebook-faca9-default-rtdb.firebaseio.com/"
        };

        // 2. Client는 'Config'가 아니라 'Client' 인터페이스여야 합니다.
        IFirebaseClient Client; //client는 파이어베이스를 의미한다.

        public Form1()
        {
            InitializeComponent();

        } // Form1 생성자 닫기  

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
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

        //추가
        private async void btnInsert_Click(object sender, EventArgs e)
        {
            var d = new Data
            {
                Id = txtID.Text,
                SId = txtSid.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text,

            };
            SetResponse s = await Client.SetAsync("pBook/" + d.Id, d);

            Data r = s.ResultAs<Data>();
            MessageBox.Show(d.Id + "빈 데이터 삽입");
        }

        private async void btnInsert_Click_1(object sender, EventArgs e) //async void 로 고쳐준다.
        {
            var d = new Data
            {
                Id = txtID.Text,
                SId = txtSid.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text,

            };
            SetResponse s = await Client.SetAsync("Hooing/" + d.Id, d); //pBook은 저장위치 

            Data r = s.ResultAs<Data>();                           
            MessageBox.Show(d.Id + "빈 데이터 삽입");        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           txtID.Text = "";
            txtSid.Text = string.Empty;
            txtName.Text = "";
            txtPhone.Text = "";
            


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

