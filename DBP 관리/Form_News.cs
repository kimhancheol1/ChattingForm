using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DBP_관리 {
	public partial class Form_News : Form {
		const string _apiUrl = "https://openapi.naver.com/v1/search/news.json";
		const string _clientId = "GByZDQLSAqf52PHTstf2"; //Application Client ID 입력
		const string _clientSecret = "mHD7hN0rQn"; //Application Client Secret 입력

		public Form_News(string user_ID) {
			InitializeComponent();

			Load_User_Config(user_ID);
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
			this.label_News_Title.BackColor = this.BackColor;
			this.label_News_Title.ForeColor = this.ForeColor;
			this.label_News_Keyword.BackColor = this.BackColor;
			this.label_News_Keyword.ForeColor = this.ForeColor;
			this.label_News_Count.BackColor = this.BackColor;
			this.label_News_Count.ForeColor = this.ForeColor;
			this.trackBar_News_Count.BackColor = this.BackColor;
			this.groupBox_News_Search.BackColor = this.BackColor;
			this.groupBox_News_Search.ForeColor = this.ForeColor;
			this.groupBox_News_Result.BackColor = this.BackColor;
			this.groupBox_News_Result.ForeColor = this.ForeColor;
			this.button_News_Search.BackColor = this.ForeColor;
			this.button_News_Search.ForeColor = this.BackColor;
		}

		private void button_News_Search_Click(object sender, EventArgs e) {
			try {
				string results = getResults();
				results = results.Replace("<b>", "");
				results = results.Replace("</b>", "");
				results = results.Replace("&apos;", "");
				results = results.Replace("&lt;", "<");
				results = results.Replace("&gt;", ">");

				var parseJson = JObject.Parse(results);
				var countsOfDisplay = Convert.ToInt32(parseJson["display"]);
				var countsOfResults = Convert.ToInt32(parseJson["total"]);

				listView_News_Result.Items.Clear();
				for (int i = 0; i < countsOfDisplay; i++) {
					ListViewItem item = new ListViewItem((i + 1).ToString());

					var title = parseJson["items"][i]["title"].ToString();
					title = title.Replace("</b>", "");
					title = title.Replace("&quot;", "\"");

					var link = parseJson["items"][i]["link"].ToString();

					item.SubItems.Add(title);
					item.SubItems.Add(link);

					listView_News_Result.Items.Add(item);
				}
			}
			catch (Exception exc) {
				Debug.WriteLine(exc.Message);
			}
		}

		private string getResults() {
			string keyword = textBox_News_Keyword.Text;
			string display = trackBar_News_Count.Value.ToString();
			string sort = "date";

			string query = string.Format("?query={0}&display={1}sort={2}", keyword, display, sort);

			WebRequest request = WebRequest.Create(_apiUrl + query);
			request.Headers.Add("X-Naver-Client-Id", _clientId);
			request.Headers.Add("X-Naver-Client-Secret", _clientSecret);

			string requestResult = "";
			using (var response = request.GetResponse()) {
				using (Stream dataStream = response.GetResponseStream()) {
					using (var reader = new StreamReader(dataStream)) {
						requestResult = reader.ReadToEnd();
					}
				}
			}

			return requestResult;
		}

		private void listView_News_Result_SelectedIndexChanged(object sender, EventArgs e) {
			//클릭하면 기본 브라우저를 여는 기능..을 추가하려 했으나 크래시가 나서 제거. 그냥 목록만 보여주도록..

			//int index = listView_News_Result.SelectedItems[0].Index;
			//string link = listView_News_Result.Items[index].SubItems[2].Text;
			//System.Diagnostics.Process.Start(link);
		}
	}
}
