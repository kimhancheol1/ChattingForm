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
	public partial class Form_Birthday : Form {
		public Form_Birthday(string user_ID) {
			InitializeComponent();

			Load_User_Config(user_ID);

			label_Birthday_Title.Text = DateTime.Now.Month + "월 생일 목록";
			Load_Birthday_Today_List();
			Load_Birthday_Month_List();
		}

		private void Load_User_Config(string user_ID) {
			//원래 저장된 테마 데이터 불러오기 및 적용
			string selectedColor = "";

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT Back_Color FROM USER_Config WHERE User_ID = " + user_ID + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				if (!rdr.Read()) {
					//기존 데이터가 없다면 기본 다크 모드
					selectedColor = "DarkMode";
					Apply_Mode(selectedColor);
					return;
				}

				selectedColor = rdr[0].ToString();
			}

			Apply_Mode(selectedColor);
		}

		private void Apply_Mode(string selectedColor) {
			if (selectedColor.Equals("DarkMode")) {
				this.BackColor = Color.FromArgb(66, 66, 66);
				this.ForeColor = Color.White;
			}
			else {
				this.BackColor = Color.White;
				this.ForeColor = Color.FromArgb(66, 66, 66);
			}
			this.label_Birthday_Title.BackColor = this.BackColor;
			this.label_Birthday_Title.ForeColor = this.ForeColor;
			this.groupBox_Birthday_Today.BackColor = this.BackColor;
			this.groupBox_Birthday_Today.ForeColor = this.ForeColor;
			this.groupBox_Birthday_Month.BackColor = this.BackColor;
			this.groupBox_Birthday_Month.ForeColor = this.ForeColor;
		}

		private void Load_Birthday_Today_List() {
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, USER.USER_name FROM department, team, USER WHERE USER.department_id = department.id AND USER.team_id = team.id AND MONTH(USER.USER_birth) = '" + DateTime.Now.Month + "' AND DAY(USER.USER_birth) = '" + DateTime.Now.Day + "';";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				listBox_Birthday_Today.Items.Clear();

				while (rdr.Read()) {
					listBox_Birthday_Today.Items.Add(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString()  + " (" + DateTime.Now.Month + "월 " + DateTime.Now.Day + "일)");
				}
			}

			if (listBox_Birthday_Today.Items.Count == 0)
				listBox_Birthday_Today.Items.Add("오늘(" + DateTime.Now.Month + "월 " + DateTime.Now.Day + "일)이 생일인 사람은 없습니다.");
		}

		private void Load_Birthday_Month_List() {
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, USER.USER_name, MONTH(USER.USER_birth), DAY(USER.USER_birth) FROM department, team, USER WHERE USER.department_id = department.id AND USER.team_id = team.id AND MONTH(USER.USER_birth) = '" + DateTime.Now.Month + "' ORDER BY DAY(USER.USER_birth), department.dpt_name, team.team_name, USER.USER_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				listBox_Birthday_Month.Items.Clear();

				while (rdr.Read()) {
					listBox_Birthday_Month.Items.Add(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString() + " (" + rdr[3].ToString() + "월 " + rdr[4].ToString() + "일)");	
				}
			}

			if (listBox_Birthday_Month.Items.Count == 0)
				listBox_Birthday_Month.Items.Add("이번 달에 생일인 사람은 없습니다.");
		}
	}
}
