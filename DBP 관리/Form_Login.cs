using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_관리
{
    public partial class Form_Login : Form {
        public Form_Login() {
            InitializeComponent();
            LoginManager.Instance.GetWeather();
        }


        private void EnterLogin(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Login_Click(sender, e);
            }
        }

        private void ResistIn_Click(object sender, EventArgs e) {
            // 현재 폼을 숨김
            this.Hide();
            Point tempPoint = this.Location;
            Form_Resist resist = new Form_Resist();
            resist.Location = tempPoint;
            resist.Owner = this;
            resist.Show();
        }


        public void Login_Click(object sender, EventArgs e) {
            LoginManager._Login.OnLogin(txt_Login.Text, txt_Password.Text, Convert.ToInt32(autoInputCheck.Checked), Convert.ToInt32(autoLoginCheck.Checked), LoginManager.Instance.getIP(), this);
        }

        public void GoAdminLogin(object sender, EventArgs e) {
            this.Hide();
            Point tempPoint = this.Location;
            FormAdmin_Login fal = new FormAdmin_Login();
            fal.Location = tempPoint;
            fal.Owner = this;
            fal.Show();
        }

        private void Form_Login_Load(object sender, EventArgs e) {
            Debug.WriteLine("로그아웃");
            LoginManager._Login.AutoBox(autoInputCheck, autoLoginCheck, this.txt_Login, this.txt_Password, this);
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Login_Click(sender, e);
            }
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e) {
			System.Diagnostics.Process.GetCurrentProcess().Kill();
		}
	}
}

