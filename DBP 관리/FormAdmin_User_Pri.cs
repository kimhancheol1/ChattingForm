using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;

namespace DBP_관리 {
	public partial class FormAdmin_User_Pri : Form {
		List<string> list_PriChat = new List<string>();
		List<string> list_PriVisible = new List<string>();
		private string user_name;
		private int user_id;

		public FormAdmin_User_Pri(string user_name, int user_id) {
			InitializeComponent();

			this.user_name = user_name;
			this.user_id = user_id;	//이는 USER 테이블의 User_id가 아닌, ID임(인덱스).

			label_Pri_Title.Text = user_name + " 권한 조정";

			Load_treeView_Pri_Visible(user_id);
			Load_PriChat(user_id);
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

		private void Load_treeView_Pri_Visible(int user_id) {
			//보기 권한 트리뷰(부서-팀-직원, 선택한 유저 제외) 출력

			list_PriVisible.Clear();
			treeView_Pri_Visible.Nodes.Clear();

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
						tn = SearchNode(rdr[0].ToString(), treeView_Pri_Visible.Nodes[0]); //부서컬럼이 현재트리에 있는지확인

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
						tn = SearchNode(rdr[0].ToString(), treeView_Pri_Visible.Nodes[0]);

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
						treeView_Pri_Visible.Nodes.Add(department);

					i++;
				}
			}

			treeView_Pri_Visible.ExpandAll();

			Check_Invisible_Users(user_id);
		}

		private void Check_Invisible_Users(int user_id) {
			//이미 사용자와 보기 제한을 걸었던 부서, 팀, 직원은 체크를 해둬야함.

			//부서 체크
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name FROM department, USER_Visible WHERE USER_Visible.UnableChat_Dpt_ID = department.id AND USER_Visible.User_ID = " + user_id +";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					string department_name = rdr[0].ToString();
					TreeNode dptNode = SearchNode(department_name, treeView_Pri_Visible.Nodes[0]);

					dptNode.Checked = true;
				}
			}

			//팀 체크
			query = "SELECT department.dpt_name, group_concat(team.team_name) FROM department, team, USER_Visible WHERE USER_Visible.UnableChat_Team_ID = team.id AND USER_Visible.User_ID = " + user_id + " AND department.id = team.dpt_id GROUP BY department.dpt_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					string department_name = rdr[0].ToString();
					string[] team_list = rdr[1].ToString().Split(",");

					TreeNode dptNode = SearchNode(department_name, treeView_Pri_Visible.Nodes[0]);
					foreach (string team_name in team_list) {
						TreeNode teamNode = SearchNode(team_name, dptNode);

						if (teamNode.Checked == false)
							teamNode.Checked = true;
					}
				}
			}

			//직원 체크
			query = "SELECT department.dpt_name, team.team_name, group_concat(USER.USER_name) FROM department, team, USER, USER_Visible WHERE USER_Visible.UnableChat_User_ID = USER.ID AND USER_Visible.User_ID = " + user_id + " AND department.id = USER.department_id AND team.id = USER.team_id GROUP BY department.dpt_name, team.team_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					string department_name = rdr[0].ToString();
					string team_name = rdr[1].ToString();
					string[] user_list = rdr[2].ToString().Split(",");

					TreeNode dptNode = SearchNode(department_name, treeView_Pri_Visible.Nodes[0]);
					TreeNode teamNode = SearchNode(team_name, dptNode);
					foreach (string user_name in user_list) {
						TreeNode userNode = SearchNode(user_name, teamNode);

						if (userNode.Checked == false)
							userNode.Checked = true;
					}
				}
			}
		}

		private void ChildNodeChecking(TreeNode selectNode) {
			//체크한 노드의 자식 노드들 체크
			foreach (TreeNode tn in selectNode.Nodes) {
				tn.Checked = selectNode.Checked;
				ChildNodeChecking(tn);
			}
			return;
		}

		private void ParentNodeChecking(TreeNode selectNode) {
			//체크한 노드가 부모의 유일한 자식 노드라면, 부모 노드도 체크
			TreeNode t = selectNode.Parent;
			if (t != null) {
				t.Checked = true;
				foreach (TreeNode tn in t.Nodes) {
					if (!tn.Checked) {
						t.Checked = false;
						break;
					}
				}
				ParentNodeChecking(t);
			}
		}

		private void treeView_Pri_Visible_AfterCheck(object sender, TreeViewEventArgs e) {
			//노드가 체크되었을 경우 체크한 노드에 대해서 자식과 부모 노드 체크 처리
			treeView_Pri_Visible.AfterCheck -= treeView_Pri_Visible_AfterCheck;
			ChildNodeChecking(e.Node);
			ParentNodeChecking(e.Node);
			treeView_Pri_Visible.AfterCheck += treeView_Pri_Visible_AfterCheck;
		}

		private void treeView_Pri_Visible_AfterSelect(object sender, TreeViewEventArgs e) {
			//체크박스만 체크하도록 이름 선택시 선택 해제
			treeView_Pri_Visible.SelectedNode = null;
		}

		private void PrintRecursive(TreeNode treeNode) {
			if (treeNode.Checked == true) {
				if (treeNode.Parent == null)    //부서라면
					list_PriVisible.Add(treeNode.Text + " ." + " .");
				else if (treeNode.Parent != null && treeNode.Parent.Parent == null && treeNode.Parent.Checked != true) //팀이고, 부서가 체크되지 않았다면
					list_PriVisible.Add(treeNode.Parent.Text + " " + treeNode.Text + " .");
				else if (treeNode.Parent != null && treeNode.Parent.Parent != null && treeNode.Parent.Checked != true && treeNode.Parent.Parent.Checked != true) //사용자고, 부서와 팀이 체크되지 않았다면
					list_PriVisible.Add(treeNode.Parent.Parent.Text + " " + treeNode.Parent.Text + " " + treeNode.Text);
			}

			foreach (TreeNode tn in treeNode.Nodes) {
				PrintRecursive(tn);
			}
		}

		// Call the procedure using the TreeView.  
		private void CallRecursive(TreeView treeView) {
			foreach (TreeNode n in treeView.Nodes) {
				PrintRecursive(n);
			}
		}

		private void button_Pri_Visible_Click(object sender, EventArgs e) {
			//트리뷰 순회하면서 리스트에 넣기(부서-팀-직원 순서)
			CallRecursive(treeView_Pri_Visible);

			//INSERT 전에 체크 해제, 즉 기존의 보기 제한을 해제했을 수 있으므로 선택한 사용자의 보기 제한 목록을 DELETE하기
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "DELETE FROM USER_Visible WHERE User_ID = " + user_id + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) { }
			}

			//이후 리스트에 저장된 목록을 불러 하나씩 하나씩 INSERT하기
			for (int i = 0; i < list_PriVisible.Count; i++) {
				string[] info = list_PriVisible[i].Split(" ");
				string dpt = info[0];
				string team = info[1];
				string user = info[2];

				if (team.Equals(".") && user.Equals(".")) {
					query = "INSERT INTO USER_Visible VALUES(" + user_id + ", (SELECT department.id FROM department WHERE department.dpt_name = '" + dpt + "'), 0, 0);";
				}
				else if (!team.Equals(".") && user.Equals(".")) {
					query = "INSERT INTO USER_Visible VALUES(" + user_id + ", 0, (SELECT team.id FROM team WHERE team.dpt_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + dpt + "') AND team_name = '" + team + "'), 0);";
				}
				else if (!team.Equals(".") && !user.Equals(".")) {
					query = "INSERT INTO USER_Visible VALUES(" + user_id + ", 0, 0, (SELECT USER.ID FROM USER WHERE USER.department_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + dpt + "') AND USER.team_id = (SELECT team.id FROM team WHERE team.team_name = '" + team + "') AND USER_name = '" + user + "'));";
				}

				using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
					connection.Open();
					MySqlCommand cmd = new MySqlCommand(query, connection);
					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read()) { }
				}
			}

			MessageBox.Show("보기 제한 갱신 완료");
			Load_treeView_Pri_Visible(user_id);
		}

		private void Load_PriChat(int user_id) {
			//대화 제한 리스트 로드
			checkedListBox_Pri_Chat.Items.Clear();
			list_PriChat.Clear();

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name, team_name, USER_name FROM department, team, USER WHERE team.dpt_id = department.id AND department.id = USER.department_id AND team.id = USER.team_id AND USER.ID != " + user_id + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					checkedListBox_Pri_Chat.Items.Add(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString());
				}
			}

			Check_PriChat(user_id);
		}

		private void Check_PriChat(int user_id) {
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, USER.USER_name FROM department, team, USER WHERE department.id = USER.department_id AND team.id = USER.team_id AND USER.ID IN(SELECT User_ID2 FROM USER_PriChat WHERE User_ID1 = " + user_id + ");";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					for (int i = 0; i < checkedListBox_Pri_Chat.Items.Count; i++) {
						if (checkedListBox_Pri_Chat.Items[i].ToString().Equals(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString())) {
							checkedListBox_Pri_Chat.SetItemChecked(i, true);
						}
					}
				}
			}

			query = "SELECT department.dpt_name, team.team_name, USER.USER_name FROM department, team, USER WHERE department.id = USER.department_id AND team.id = USER.team_id AND USER.ID IN(SELECT User_ID1 FROM USER_PriChat WHERE User_ID2 = " + user_id + ");";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					for (int i = 0; i < checkedListBox_Pri_Chat.Items.Count; i++) {
						if (checkedListBox_Pri_Chat.Items[i].ToString().Equals(rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString())) {
							checkedListBox_Pri_Chat.SetItemChecked(i, true);
						}
					}
				}
			}
		}

		private void button_Pri_Chat_Click(object sender, EventArgs e) {
			//INSERT 전에 체크 해제, 즉 기존의 대화 제한을 해제했을 수 있으므로 선택한 사용자의 대화 제한 목록을 DELETE하기
			for(int i = 0; i < checkedListBox_Pri_Chat.CheckedItems.Count; i++) {
				list_PriChat.Add(checkedListBox_Pri_Chat.CheckedItems[i].ToString());
			}

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "DELETE FROM USER_PriChat WHERE (User_ID1 = " + user_id + ") OR (USER_ID2 = " + user_id + ");";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {	}
			}

			foreach(string str in list_PriChat) {
				string[] info = str.Split(" ");
				string dpt = info[0];
				string team = info[1];
				string user = info[2];

				query = "INSERT INTO USER_PriChat(User_ID1, User_ID2) VALUES(" + user_id + ", (SELECT USER.ID FROM USER WHERE USER.department_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + dpt + "') AND USER.team_id = (SELECT team.id FROM team WHERE team.team_name = '" + team + "') AND USER.USER_name = '" + user +"'));";
				using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
					connection.Open();
					MySqlCommand cmd = new MySqlCommand(query, connection);
					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read()) { }
				}
			}

			MessageBox.Show("대화 제한 적용 완료");
			Load_PriChat(user_id);
		}
	}
}