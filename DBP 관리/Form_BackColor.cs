using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_관리 {
	public partial class Form_BackColor : Form {
		string user_ID = "";
		string selectedColor = "";
		public Form_BackColor(string user_ID) {
			InitializeComponent();

			//매개변수와 생성자 사용시 인자로 user_ID(USER.ID 컬럼 사용) 추가할 것...
			this.user_ID = user_ID;

			Load_User_Config(user_ID);
		}

		private void Load_User_Config(string user_ID) {
			//원래 저장된 테마 데이터 불러오기

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT Back_Color FROM USER_Config WHERE User_ID = " + user_ID + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				if (!rdr.Read()) {
					//기존 데이터가 없다면 기본 다크 모드
					selectedColor = "DarkMode";
					checkBox_BackColor_DarkMode.Checked = true;
					return;
				}

				selectedColor = rdr[0].ToString();
			}

			if (selectedColor.Equals("DarkMode"))
				checkBox_BackColor_DarkMode.Checked = true;
			else
				checkBox_BackColor_LightMode.Checked = true;
		}

		private void checkBox_BackColor_DarkMode_CheckedChanged(object sender, EventArgs e) {
			//다크모드 체크시
			if (checkBox_BackColor_DarkMode.Checked == true) {
				checkBox_BackColor_LightMode.Checked = false;
				selectedColor = "DarkMode";

				this.BackColor = Color.FromArgb(66, 66, 66);
				this.ForeColor = Color.White;
				this.button_BackColor.BackColor = this.ForeColor;
				this.button_BackColor.ForeColor = this.BackColor;
				this.groupBox_BackColor.BackColor = this.BackColor;
				this.groupBox_BackColor.ForeColor = this.ForeColor;
				this.checkBox_BackColor_DarkMode.ForeColor = this.ForeColor;
				this.checkBox_BackColor_DarkMode.BackColor = this.BackColor;
				this.checkBox_BackColor_LightMode.ForeColor = this.ForeColor;
				this.checkBox_BackColor_LightMode.BackColor = this.BackColor;
			}
		}

		private void checkBox_BackColor_LightMode_CheckedChanged(object sender, EventArgs e) {
			//라이트모드 체크시
			if (checkBox_BackColor_LightMode.Checked == true) {
				checkBox_BackColor_DarkMode.Checked = false;
				selectedColor = "LightMode";

				this.BackColor = Color.White;
				this.ForeColor = Color.FromArgb(66, 66, 66);
				this.button_BackColor.BackColor = this.ForeColor;
				this.button_BackColor.ForeColor = this.BackColor;
				this.groupBox_BackColor.BackColor = this.BackColor;
				this.groupBox_BackColor.ForeColor = this.ForeColor;
				this.checkBox_BackColor_DarkMode.ForeColor = this.ForeColor;
				this.checkBox_BackColor_DarkMode.BackColor = this.BackColor;
				this.checkBox_BackColor_LightMode.ForeColor = this.ForeColor;
				this.checkBox_BackColor_LightMode.BackColor = this.BackColor;
			}
		}

		private void button_BackColor_Click(object sender, EventArgs e) {
			//적용하기 버튼 클릭시 저장된 현재 모드 INSERT 혹은 UPDATE

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "INSERT INTO USER_Config(User_ID, Back_Color) VALUES (" + user_ID + ", '" + selectedColor + "') ON DUPLICATE KEY UPDATE Back_Color = '" + selectedColor + "';";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) { }
			}

			MessageBox.Show("적용 완료");
		}
	}
}
