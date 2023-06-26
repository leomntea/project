using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace PC_room_management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "RyJSDHUc6ryYXk4URX8b8tnWMmNhqTc8p2s8LF7i",
            BasePath = "https://pc-room-management-default-rtdb.firebaseio.com"
        };
        IFirebaseClient client;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fbc);
            }
            catch
            {
                MessageBox.Show("문제 발생");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = client.Get("가입자 명단/" + tbId.Text);
            Upload upd = result.ResultAs<Upload>();

            if(upd == null || tbPw.Text != upd.pw)
            {
                MessageBox.Show("실패");
            }
            else
            {
                MessageBox.Show("성공");
                LoginOk loginOk = new LoginOk();
                loginOk.Show();
               
            }

             
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
