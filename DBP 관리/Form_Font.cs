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

namespace DBP_관리
{
    public partial class Form_Font : Form
    {
        private int userid = 0;
        public Form_Font(string user_id)
        {
            InitializeComponent();
            this.userid = Convert.ToInt32(user_id);
            Load_User_Config(user_id);
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
            this.label_BackColor_Title.BackColor = this.BackColor;
			this.label_BackColor_Title.ForeColor = this.ForeColor;
			this.label3.BackColor = this.BackColor;
			this.label3.ForeColor = this.ForeColor;
            this.label4.BackColor = this.BackColor;
			this.label4.ForeColor = this.ForeColor;
            this.groupBox_BackColor.BackColor = this.BackColor;
			this.groupBox_BackColor.ForeColor = this.ForeColor;
            this.button_BackColor.BackColor = this.ForeColor;
			this.button_BackColor.ForeColor = this.BackColor;
		}

		private void button_BackColor_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedItem == null && comboBox4.SelectedItem == null)
            {
                MessageBox.Show("폰트가 선택되어있지 않습니다.");
            }
            else
            {
                string font = comboBox4.SelectedItem.ToString();
                int size = Convert.ToInt32(comboBox3.SelectedItem.ToString());

                Change_Font(size, this.userid, font);
            }
        }

        //size = 폰트크기, user = 현재 로그인한 유저 고유인덱스
        public void Change_Font(int size, int user, string Font)
        {
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "INSERT INTO USER_Config(User_ID, Font, Font_Size) VALUES ("+ user +", '"+ Font +"', "+ size+ ") ON DUPLICATE KEY UPDATE Font = '"+ Font + "', Font_Size = "+ size +";";

            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("폰트가 설정되었습니다.");
                this.Close();
            }
        }
    }
}
