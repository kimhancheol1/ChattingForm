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
using System.Xml;

namespace DBP_관리 {
	public partial class Form_Weather : Form {
		string strURL = "http://www.kma.go.kr/weather/forecast/mid-term-xml.jsp";

		public Form_Weather(string user_id) {
			InitializeComponent();

			Load_User_Config(user_id);

			Load_Today_Weather_Info();
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
			this.label_Weather_Title.BackColor = this.BackColor;
			this.label_Weather_Title.ForeColor = this.ForeColor;
			this.groupBox_Weather.BackColor = this.BackColor;
			this.groupBox_Weather.ForeColor = this.ForeColor;
		}

		private void Load_Today_Weather_Info() {
			try {
				using (XmlReader xr = XmlReader.Create(strURL)) {
					XmlWriterSettings ws = new XmlWriterSettings();
					ws.Indent = true;

					while (xr.Read()) {
						switch (xr.NodeType) {
							case XmlNodeType.CDATA: {
								string[] list = xr.Value.ToString().Replace("<br />", " ").Split("○");
								foreach(string str in list) {
									if (!string.IsNullOrEmpty(str))
										listBox_Weather.Items.Add(str);
								}
								break;
							}
							case XmlNodeType.Element: {
								break;
							}
							case XmlNodeType.Text: {
								break;
							}
							case XmlNodeType.XmlDeclaration: {
								break;
							}
							case XmlNodeType.ProcessingInstruction: {
								break;
							}
							case XmlNodeType.Comment: {
								break;
							}
							case XmlNodeType.EndElement: {
								break;
							}
						}
					}
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message.ToString());
			}
		}
	}
}
