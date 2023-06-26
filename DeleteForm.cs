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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "RyJSDHUc6ryYXk4URX8b8tnWMmNhqTc8p2s8LF7i",
            BasePath = "https://pc-room-management-default-rtdb.firebaseio.com"
        };
        IFirebaseClient client;

        private void button1_Click(object sender, EventArgs e)
        {
            Upload upd2 = new Upload()
            {
                name = tbName.Text,
                id = tbId.Text,
                pw = tbPw.Text,
                em = tbEm.Text,
            };
            var result = client.Delete("가입자 명단/" +tbId.Text);
            MessageBox.Show("정보 삭제 완료 ");
        }

        private void DeleteForm_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
