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
    public delegate void DataEventHandler(string data);

    public partial class Form_ChangeProfile : Form
    {
        public DataEventHandler dataEvent;
        string receivedData;
        private string originNick;
        public Form_ChangeProfile(string data, string ID)
        {
            receivedData = data;
            InitializeComponent();
            Load_User_Config(ID);
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
            this.pictureBox1.BackColor = this.BackColor;
            this.label1.BackColor = this.BackColor;
			this.label1.ForeColor = this.ForeColor;
			this.label2.BackColor = this.BackColor;
			this.label2.ForeColor = this.ForeColor;
			this.label3.BackColor = this.BackColor;
			this.label3.ForeColor = this.ForeColor;
			this.label4.BackColor = this.BackColor;
			this.label4.ForeColor = this.ForeColor;
            this.label7.BackColor = this.BackColor;
            this.label7.ForeColor = this.ForeColor;
            this.btn_OK.BackColor = this.ForeColor;
			this.btn_OK.ForeColor = this.BackColor;
			this.button1.BackColor = this.ForeColor;
			this.button1.ForeColor = this.BackColor;
			this.button2.BackColor = this.ForeColor;
			this.button2.ForeColor = this.BackColor;
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_address_click(object sender, EventArgs e)
        {
            Form_Address fd = new Form_Address();
            fd.sendEvent += new DataGetEventHandler(DataGet);
            fd.ShowDialog();
        }
        private void DataGet(string data)
        {
            string datas = data;
            var ad = datas.Split('\n');

            txt_zipCode.Text = ad[0];
            txt_roadAddress.Text = ad[1];
            txt_landlordAddress.Text = ad[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginManager.Instance.SetImage(openFileDialog1, pictureBox1, receivedData);
        }

        private void Form_ChangeProfile_Load(object sender, EventArgs e)
        {
            LoginManager.Instance.LoadUserData(receivedData, pictureBox1, txt_name, txt_nickname, txt_zipCode, txt_roadAddress, txt_landlordAddress);
            originNick = txt_nickname.Text;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            LoginManager.Instance.ChangeProfile(receivedData, txt_name.Text, originNick, txt_nickname.Text, txt_password.Text, txt_zipCode.Text, txt_roadAddress.Text, txt_landlordAddress.Text);
            dataEvent("변경");
            this.Close();
        }
    }
}
