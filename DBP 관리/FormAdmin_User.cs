using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBP_관리 {
	public partial class FormAdmin_User : Form {
		public FormAdmin_User() {
			InitializeComponent();
			load_user_treeview();

			dateTimePicker_User_Log1.CustomFormat = "yyyy-MM-dd hh:mm";
			dateTimePicker_User_Log1.Format = DateTimePickerFormat.Custom;

			dateTimePicker_User_Log2.CustomFormat = "yyyy-MM-dd hh:mm";
			dateTimePicker_User_Log2.Format = DateTimePickerFormat.Custom;

			dataGridView_User_Log.DefaultCellStyle.ForeColor = Color.Black;
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

		private void load_user_treeview() {
			//부서-팀-사용자 트리뷰 출력

			treeView_User.Nodes.Clear();

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name, group_concat(USER_name) FROM s5469698.department, team, USER WHERE department.id = team.dpt_id AND USER.team_id = team.id GROUP BY department.dpt_name, team.team_name;";

			//사람이 없는 부서도 모두 출력시 아래 쿼리 사용
			//SELECT department.dpt_name, team.team_name, group_concat(USER_name) FROM s5469698.department left outer join team on department.id = team.dpt_id left outer join USER on USER.team_id = team.id group by department.dpt_name, team.team_name;

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
						tn = SearchNode(rdr[0].ToString(), treeView_User.Nodes[0]); //부서컬럼이 현재트리에 있는지확인

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
						tn = SearchNode(rdr[0].ToString(), treeView_User.Nodes[0]);

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
						treeView_User.Nodes.Add(department);

					i++;
				}
			}

			treeView_User.ExpandAll();
		}

		private int get_user_id(string user_name, string user_dpt, string user_team) {
			//사용자의 이름, 소속 부서명, 소속 팀명을 가져와서 사용자 id 반환

			int user_id = 0;

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT USER.ID FROM s5469698.USER, department, team WHERE USER_name = '" + user_name + "' AND department.dpt_name = '" + user_dpt + "' AND team.team_name = '" + user_team + "' AND department_id = department.id AND team_id = team.id;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					string str = rdr[0].ToString();
					user_id = Int32.Parse(str);
				}
			}

			return user_id;
		}

		private string get_user_dpt(int user_id) {
			//사용자의 id를 통해서 사용자의 소속 부서명 가져오기

			string user_dpt = "";
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT department.dpt_name, team.team_name FROM s5469698.USER, department, team WHERE USER.ID = " + user_id + " AND department_id = department.id AND team_id = team.id;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				DataTable dt = new DataTable();
				dt.Load(rdr);

				foreach (DataRow dr in dt.Rows) {
					user_dpt += dr["dpt_name"].ToString();
					user_dpt += " " + dr["team_name"].ToString();
				}
			}

			return user_dpt;
		}

		private void load_dptchange_treeview(int user_id) {
			//부서 변경의 부서-팀 트리뷰 출력

			treeView_User_DptChange.Nodes.Clear();
			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT dpt_name, group_concat(team_name) FROM s5469698.department left outer join team on department.id = team.dpt_id AND team.id != (SELECT USER.team_id FROM USER WHERE USER.ID = " + user_id + ") group by dpt_name;";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) {
					TreeNode department = new TreeNode(rdr[0].ToString());
					string teamname = rdr[1].ToString();
					string[] str_list = teamname.Split(",");

					foreach (string str in str_list) {
						department.Nodes.Add(str);
					}

					treeView_User_DptChange.Nodes.Add(department);
				}
			}
		}

		private void treeView_User_AfterSelect(object sender, TreeViewEventArgs e) {
			//사용자 목록 트리뷰 선택시

			if (treeView_User.SelectedNode.Nodes.Count == 0) {   //선택한 노드 아래에 더 이상 노드가 없다 = 자식 노드(직원)를 선택했다.
				string user_name = treeView_User.SelectedNode.Text;
				string user_dpt = treeView_User.SelectedNode.Parent.Parent.Text;
				string user_team = treeView_User.SelectedNode.Parent.Text;
				int user_id = get_user_id(user_name, user_dpt, user_team);

				label_User_Name.Text = "관리할 사용자 : " + user_name;
				label_User_DptChange_Name1.Text = "현재 소속 : " + get_user_dpt(user_id);

				load_dptchange_treeview(user_id);
				button_User_Pri.Enabled = true;
				button_User_Chat.Enabled = true;
				load_user_log();
				button_User_Log.Enabled = true;
				dateTimePicker_User_Log1.Enabled = true;
			}
			else
				treeView_User.SelectedNode = null;  //아니면 선택 해제
		}

		private void treeView_User_DptChange_AfterSelect(object sender, TreeViewEventArgs e) {
			//부서 변경 트리뷰 선택시
			
			if (treeView_User_DptChange.SelectedNode.Nodes.Count == 0) { //트리뷰에서 자식 노드를 선택했다면
				label_User_DptChange_Name2.Text = "변경 소속 : " + treeView_User_DptChange.SelectedNode.Parent.Text + " " + treeView_User_DptChange.SelectedNode.Text;
				button_User_DptChange.Enabled = true;
			}
			else
				treeView_User_DptChange.SelectedNode = null;    //아니면 선택 해제
		}

		private void button_User_DptChange_Click(object sender, EventArgs e) {
			//사용자 부서 변경

			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Parent.Text;
			string user_team = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt, user_team);

			string user_dptchange_team = treeView_User_DptChange.SelectedNode.Text;
			string user_dptchange_dpt = treeView_User_DptChange.SelectedNode.Parent.Text;

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "UPDATE s5469698.USER SET USER.department_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + user_dptchange_dpt + "')," +
						   " USER.team_id = (SELECT team.id FROM team WHERE team.team_name = '" + user_dptchange_team + "' AND team.dpt_id = (SELECT department.id FROM department WHERE department.dpt_name = '" + user_dptchange_dpt + "'))" +
						   "WHERE USER.ID = " + user_id + ";";
			
			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read()) { }
			}

			MessageBox.Show(user_name + "의 소속이 변경되었습니다.");

			load_user_treeview();
			button_User_Pri.Enabled = false;
			button_User_Chat.Enabled = false;
			button_User_Log.Enabled = false;
			button_User_DptChange.Enabled = false;
			dateTimePicker_User_Log1.Enabled = false;

			label_User_Name.Text = "관리할 사용자 : [사용자]";
			label_User_DptChange_Name1.Text = "현재 소속 : [부서] [팀]";
			label_User_DptChange_Name2.Text = "변경 소속 : [부서] [팀]";
			treeView_User_DptChange.Nodes.Clear();
			dataGridView_User_Log.DataSource = null;
			dataGridView_User_Log.Refresh();
		}

		private void load_user_log() {
			//선택한 사용자의 로그 내역 출력
			
			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Parent.Text;
			string user_team = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt, user_team);

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT log_time AS '접속 시간', CASE WHEN log_type = 'in' THEN '로그인' WHEN log_type = 'out' THEN '로그아웃' END AS '접속 종류' FROM Login_log WHERE user_id = " + user_id + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				DataTable dt = new DataTable();
				dt.Load(rdr);
				dataGridView_User_Log.DataSource = dt;
			}
		}

		private void button_User_Log_Click(object sender, EventArgs e) {
			//사용자 로그 검색

			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Parent.Text;
			string user_team = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt, user_team);

			string date1 = dateTimePicker_User_Log1.Text;
			string date2 = dateTimePicker_User_Log2.Text;

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT log_time AS '접속 시간', CASE WHEN log_type = 'in' THEN '로그인' WHEN log_type = 'out' THEN '로그아웃' END AS '접속 종류' FROM Login_log WHERE log_time BETWEEN '" + date1 + ":00' AND '" + date2 + ":59' AND user_id = " + user_id + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				DataTable dt = new DataTable();
				dt.Load(rdr);
				dataGridView_User_Log.DataSource = dt;
			}
		}

		private void button_User_Pri_Click(object sender, EventArgs e) {
			//사용자 권한 조정 폼 열기

			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Parent.Text;
			string user_team = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt, user_team);

			Point tempPoint = this.Location;
			FormAdmin_User_Pri formPri = new FormAdmin_User_Pri(user_name, user_id);
			formPri.ShowDialog();
		}

		private void button_User_Chat_Click(object sender, EventArgs e) {
			//사용자 대화 내용 검색 폼 열기

			string user_name = treeView_User.SelectedNode.Text;
			string user_dpt = treeView_User.SelectedNode.Parent.Parent.Text;
			string user_team = treeView_User.SelectedNode.Parent.Text;
			int user_id = get_user_id(user_name, user_dpt, user_team);

			FormAdmin_User_Chat formChat = new FormAdmin_User_Chat(user_name, user_id);
			formChat.ShowDialog();
		}


		//이하 네비게이션 바 버튼 클릭시 이벤트
		private void 부서관리ToolStripMenuItem_Click(object sender, EventArgs e) {
			this.Hide();
			Point tempPoint = this.Location;
			FormAdmin_Dpt formDpt = new FormAdmin_Dpt();
			formDpt.Location = tempPoint;
			formDpt.Owner = this;
			formDpt.Show();
		}

		private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("현재 사용자 관리 페이지입니다.");
		}

		private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("로그 아웃");

			this.Hide();
			Point tempPoint = this.Location;
			Form_Login formLogin = new Form_Login();
			formLogin.Location = tempPoint;
			formLogin.Owner = this;
			formLogin.Show();
		}
	}
}
