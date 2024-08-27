using Microsoft.VisualBasic.ApplicationServices;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DBP_관리 {
    public partial class FormAdmin_User_Chat : Form {
		private string user_name;
		private int user_id;
		List<string> Room_id = new List<string>();
		private string date;
		private string keyword;

		public FormAdmin_User_Chat(string user_name, int user_id) {
            InitializeComponent();

			this.user_name = user_name;
			this.user_id = user_id; //이는 USER 테이블의 User_id가 아닌, ID임(인덱스).

			date = DateTime.Now.ToString("yyyy-MM-dd");

			label_Chat_Title.Text = user_name + " 대화 검색";
			label_Chat_Search.Text = "먼저 확인할 대화 상대를 선택해주세요.";

			dateTimePicker_Chat_Time_Search.CustomFormat = "yyyy-MM-dd";
			dateTimePicker_Chat_Time_Search.Format = DateTimePickerFormat.Custom;

			Load_List_Time_Search(user_id);
			Load_List_Keyword_Search(user_id);
			Load_TreeView_Search(user_id);
		}

		private string get_user_nickname(int user_id) {
			//사용자의 번호를 가져와 닉네임 반환

			string user_nickname = "";

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT USER_nickname FROM s5469698.USER WHERE USER.ID = " + user_id + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					user_nickname = rdr[0].ToString();
				}
			}

			return user_nickname;
		}

		private void Load_List_Time_Search(int user_id) {
			//시간별 검색 리스트 박스 로드(초기 로드, 사용자의 대화방 리스트 출력)
			listBox_Chat_Time_Search.Items.Clear();

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT idRoom, USER1, USER2 FROM Room WHERE idRoom IN (SELECT idRoom FROM Room WHERE USER1 = (SELECT USER_nickname FROM USER WHERE USER.ID = " + user_id + ") OR USER2 = (SELECT USER_nickname FROM USER WHERE USER.ID = " + user_id + ") GROUP BY idRoom);";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					Room_id.Add(rdr[0].ToString());
					string user1 = rdr[1].ToString();
					string user2 = rdr[2].ToString();
					string user_nickname = get_user_nickname(user_id);

					if (user1 == user_nickname)
						listBox_Chat_Time_Search.Items.Add(user2);
					else
						listBox_Chat_Time_Search.Items.Add(user1);
				}
			}
		}

		private void Load_List_Time_Search(int user_id, string date) {
			//시간별 검색 리스트 박스 로드
			listBox_Chat_Time_Search.Items.Clear();

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT idRoom, USER1, USER2 FROM Room WHERE idRoom IN(SELECT idRoom FROM Room WHERE USER1 = (SELECT USER_nickname FROM USER WHERE USER.ID = " + user_id + ") OR USER2 = (SELECT USER_nickname FROM USER WHERE USER.ID = " + user_id + ") GROUP BY idRoom)" +
			               " AND idRoom IN (SELECT Roomid FROM Chatting WHERE (Chatting.To = (SELECT USER_id FROM USER WHERE USER.ID = " + user_id + ") OR Chatting.From = (SELECT USER_id FROM USER WHERE USER.ID = " + user_id + ")) AND Chatting.when LIKE '" + date + "%' GROUP BY Roomid);";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				Room_id.Clear();

				while (rdr.Read()) {
					Room_id.Add(rdr[0].ToString());
					string user1 = rdr[1].ToString();
					string user2 = rdr[2].ToString();
					string user_nickname = get_user_nickname(user_id);

					if (user1 == user_nickname)
						listBox_Chat_Time_Search.Items.Add(user2);
					else
						listBox_Chat_Time_Search.Items.Add(user1);
				}
			}
		}

		private void button_Chat_Time_Search_Click(object sender, EventArgs e) {
			//시간별 검색 버튼 클릭
			date = dateTimePicker_Chat_Time_Search.Text;
			Load_List_Time_Search(user_id, date);
		}

		private void listBox_Chat_Time_Search_SelectedIndexChanged(object sender, EventArgs e) {
			//시간별 검색 대화 리스트 선택시 오른쪽 listbox에 대화 내역 출력
			if (listBox_Chat_Time_Search.SelectedItem != null) {
				label_Chat_Search.Text = "선택한 대화 상대 : " + listBox_Chat_Time_Search.SelectedItem.ToString();
				listBox_Chat_Search.Items.Clear();

				string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
				string query = "SELECT Chatting.To, Chatting.From, msgText FROM Chatting WHERE Roomid = " + Room_id[listBox_Chat_Time_Search.SelectedIndex] + " AND Chatting.when LIKE '" + date + "%';";

				using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
					connection.Open();
					MySqlCommand cmd = new MySqlCommand(query, connection);
					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read()) {
						listBox_Chat_Search.Items.Add("[" + rdr[1].ToString() + "] -> [" + rdr[0].ToString() + "] : " + rdr[2].ToString());
					}
				}
			}
		}

		private void Load_List_Keyword_Search(int user_id) {
			//키워드별 검색 리스트 박스 로드(초기 로드, 사용자의 대화방 리스트 출력)
			listBox_Chat_Keyword_Search.Items.Clear();

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT idRoom, USER1, USER2 FROM Room WHERE idRoom IN (SELECT idRoom FROM Room WHERE USER1 = (SELECT USER_nickname FROM USER WHERE USER.ID = " + user_id + ") OR USER2 = (SELECT USER_nickname FROM USER WHERE USER.ID = " + user_id + ") GROUP BY idRoom);";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				Room_id.Clear();

				while (rdr.Read()) {
					Room_id.Add(rdr[0].ToString());
					string user1 = rdr[1].ToString();
					string user2 = rdr[2].ToString();
					string user_nickname = get_user_nickname(user_id);

					if (user1 == user_nickname)
						listBox_Chat_Keyword_Search.Items.Add(user2);
					else
						listBox_Chat_Keyword_Search.Items.Add(user1);
				}
			}
		}

		private void Load_List_Keyword_Search(int user_id, string keyword) {
			//키워드별 검색 리스트 박스 로드
			listBox_Chat_Keyword_Search.Items.Clear();

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT idRoom, USER1, USER2 FROM Room WHERE idRoom IN(SELECT idRoom FROM Room WHERE USER1 = (SELECT USER_nickname FROM USER WHERE USER.ID = " + user_id + ") OR USER2 = (SELECT USER_nickname FROM USER WHERE USER.ID = " + user_id + ") GROUP BY idRoom)" +
			               " AND idRoom IN (SELECT Roomid FROM Chatting WHERE (Chatting.To = (SELECT USER_id FROM USER WHERE USER.ID = " + user_id + ") OR Chatting.From = (SELECT USER_id FROM USER WHERE USER.ID = " + user_id + ")) AND Chatting.msgText LIKE '%" + keyword + "%' GROUP BY Roomid);";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				Room_id.Clear();

				while (rdr.Read()) {
					Room_id.Add(rdr[0].ToString());
					string user1 = rdr[1].ToString();
					string user2 = rdr[2].ToString();
					string user_nickname = get_user_nickname(user_id);

					if (user1 == user_nickname)
						listBox_Chat_Keyword_Search.Items.Add(user2);
					else
						listBox_Chat_Keyword_Search.Items.Add(user1);
				}
			}
		}

		private void button_Chat_Keyword_Search_Click(object sender, EventArgs e) {
			//키워드별 검색 버튼 클릭
			keyword = textBox_Chat_Keyword_Search.Text;
			Load_List_Keyword_Search(user_id, keyword);
		}

		private void listBox_Chat_Keyword_Search_SelectedIndexChanged(object sender, EventArgs e) {
			//키워드별 검색 대화 리스트 선택시 오른쪽 listbox에 대화 내역 출력
			if (listBox_Chat_Keyword_Search.SelectedItem != null) {
				label_Chat_Search.Text = "선택한 대화 상대 : " + listBox_Chat_Keyword_Search.SelectedItem.ToString();
				listBox_Chat_Search.Items.Clear();

				string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
				string query = "SELECT Chatting.To, Chatting.From, msgText FROM Chatting WHERE Roomid = " + Room_id[listBox_Chat_Keyword_Search.SelectedIndex] + " AND Chatting.msgText LIKE '%" + keyword + "%'; ";

				using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
					connection.Open();
					MySqlCommand cmd = new MySqlCommand(query, connection);
					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read()) {
						listBox_Chat_Search.Items.Add("[" + rdr[1].ToString() + "] -> [" + rdr[0].ToString() + "] : " + rdr[2].ToString());
					}
				}
			}
		}

		private TreeNode SearchNode(string SearchText, TreeNode StartNode) {
			TreeNode node = null;

			while (StartNode != null) {
				if (StartNode.Text.ToLower().Contains(SearchText.ToLower())) {
					node = StartNode;
					break;
				};
				if (StartNode.Nodes.Count != 0) {
					node = SearchNode(SearchText, StartNode.Nodes[0]);  //Recursive Search
					if (node != null) {
						break;
					};
				};
				StartNode = StartNode.NextNode;
			};

			return node;
		}

		private void Load_TreeView_Search(int user_id) {
			//사용자별 검색 트리뷰 로드(사용자별로 검색하는 것이므로, 대화 목록에 관계 없이 사람들 출력.)
			treeView_Chat_User_Search.Nodes.Clear();

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, group_concat(USER_name) FROM s5469698.department, team, USER WHERE department.id = team.dpt_id AND USER.team_id = team.id AND USER.ID != " + user_id + " GROUP BY department.dpt_name, team.team_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();
				TreeNode department = null;

				int i = 0; //두번째부터 중복확인하기 위한 변수
				int x = 0; //부서가 중복인지 확인하기 위한 변수

				while (rdr.Read()) {
					TreeNode tn = null;
					if (i >= 1)
						tn = SearchNode(rdr[0].ToString(), treeView_Chat_User_Search.Nodes[0]); //부서컬럼이 현재트리에 있는지확인

					TreeNode team = null;
					string username = null;
					string teamname = null;

					if (tn == null) { //부서가 중복이 안되어있으면
						x = 0;
						department = new TreeNode(rdr[0].ToString());

						if (rdr[1].ToString() != null)
							team = new TreeNode(rdr[1].ToString());
					}
					else { //부서 중복이 된 경우
						x = 1;
						tn = SearchNode(rdr[0].ToString(), treeView_Chat_User_Search.Nodes[0]);

						if (rdr[1].ToString() != null)
							team = new TreeNode(rdr[1].ToString());
					}

					if (rdr[2].ToString() != null) { //팀원이 있으면 팀원 추가
						username = rdr[2].ToString();
						string[] str_list = username.Split(",");

						if (department != null)
							foreach (string str in str_list) {
								team.Nodes.Add(str);
							}
					}

					department.Nodes.Add(team);

					if (x == 0) //부서가 중복이 안되있으면 상위노드(부서노드) 트리뷰에 추가
						treeView_Chat_User_Search.Nodes.Add(department);

					i++;
				}
			}

			treeView_Chat_User_Search.ExpandAll();
		}

		private void treeView_Chat_User_Search_AfterSelect(object sender, TreeViewEventArgs e) {
			//사용자별 검색 트리뷰 선택시 해당 사용자와의 대화 내역을 오른쪽 listtbox에 출력
			//대화 방이 없을 경우 메세지 박스로 알림
			if (treeView_Chat_User_Search.SelectedNode.Nodes.Count == 0) {   //선택한 노드 아래에 더 이상 노드가 없다 = 자식 노드(직원)를 선택했다.
				label_Chat_Search.Text = "선택한 대화 상대 : " + treeView_Chat_User_Search.SelectedNode.Text;
				listBox_Chat_Search.Items.Clear();

				string dpt = treeView_Chat_User_Search.SelectedNode.Parent.Parent.Text;
				string team = treeView_Chat_User_Search.SelectedNode.Parent.Text;
				string user = treeView_Chat_User_Search.SelectedNode.Text;

				string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
				string query = "SELECT Chatting.To, Chatting.From, msgText FROM Chatting WHERE (Chatting.To = (SELECT USER_id FROM USER WHERE USER.ID = " + user_id + ") OR Chatting.From = (SELECT USER_id FROM USER WHERE USER.ID = " + user_id + ")) AND (Chatting.To = (SELECT USER_id FROM USER WHERE USER.department_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + dpt + "') AND USER.team_id = (SELECT team.id FROM team WHERE team.team_name = '" + team + "') AND USER.USER_name = '" + user + "') OR Chatting.From = (SELECT USER_id FROM USER WHERE USER.department_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + dpt + "') AND USER.team_id = (SELECT team.id FROM team WHERE team.team_name = '" + team + "') AND USER.USER_name = '" + user + "'));";

				using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
					connection.Open();
					MySqlCommand cmd = new MySqlCommand(query, connection);
					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read()) {
						listBox_Chat_Search.Items.Add("[" + rdr[1].ToString() + "] -> [" + rdr[0].ToString() + "] : " + rdr[2].ToString());
					}
				}

				if (listBox_Chat_Search.Items.Count == 0)
					MessageBox.Show("대화가 없습니다.");
			}
			else
				treeView_Chat_User_Search.SelectedNode = null;  //아니면 선택 해제
		}
	}
}