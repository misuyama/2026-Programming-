using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace __26_04_27_FireBase // Program.cs와 반드시 똑같아야 합니다!
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



    //  private async void btnInsert_Click(object sender, EventArgs e)
    //  {
    //      var d = new Data
    //      {
    //          Id = txtID.Text,
    //          SId = txtSid.Text,
    //          Name = txtName.Text,
    //          Phone = txtPhone.Text
    //      };
    //
    //      SetResponse s = await Client.SetAsync("pBook/" + d.Id, d);
    //      MessageBox.Show(d.Id + " 데이터 삽입 완료");
    //  }
    //
    //  private void btnClear_Click(object sender, EventArgs e)
    //  {
    //      txtID.Text = "";
    //      txtSid.Text = string.Empty;
    //      txtName.Text = "";
    //      txtPhone.Text = "";
    //  }
    //
    //  private void btnExit_Click(object sender, EventArgs e)
    //  {
    //      this.Close();
    //  }

        private void Form1_Load_1(object sender, EventArgs e) {
            Client = new FireSharp.FirebaseClient(config);

            if (Client != null)
            {
                MessageBox.Show("client 객체 생성!");
            }

            try
            {
                var r = Client.Set("test", "OK");
                MessageBox.Show("연결 성공!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패!\n" + ex.Message);
            }
        }

      private async void button2_Click(object sender, EventArgs e)
      {
          var d = new Data
          {
              Id = txtID.Text,
              SId = txtSid.Text,
              Name = txtName.Text,
              Phone = txtPhone.Text
          };
 
          SetResponse s = await Client.SetAsync("흐에!" + d.Id, d);
          MessageBox.Show(d.Id + " 데이터 삽입 완료");
      }
 
      private void button4_Click(object sender, EventArgs e)
      {
          txtID.Text = "";
          txtSid.Text = string.Empty;
          txtName.Text = "";
          txtPhone.Text = "";
      }
  }

    class Data
    {
        public string Id { get; set; }
        public string SId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}