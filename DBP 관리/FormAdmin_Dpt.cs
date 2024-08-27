using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DBP_관리 {
	public partial class FormAdmin_Dpt : Form {
		public FormAdmin_Dpt() {
			InitializeComponent();
		}

        string pre_str = ""; // Update에 사용될 전역변수

		private void Form1_Load(object sender, EventArgs e) {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            search_treeview();
        }


        /*connect directly to DB & Treeview Add data to department with team*/
        public void search_treeview()
        {
            treeView1.Nodes.Clear();
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "SELECT dpt_name, group_concat(team_name) FROM s5469698.department left outer join team on department.id = team.dpt_id group by dpt_name";



            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    TreeNode department = new TreeNode(rdr[0].ToString());
                    string teamname = rdr[1].ToString();
                    string[] str_list = teamname.Split(",");
                    foreach (string str in str_list)
                    {
                        department.Nodes.Add(str);
                    }

                    treeView1.Nodes.Add(department);
                }
            }
        }

        /*pre_str is condition of where(query), str is keyword for update*/
        public void Update_dpt(string pre_str, string str)
        {
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "UPDATE department SET dpt_name = '" +str+ "' WHERE dpt_name = '" +pre_str+ "'";

            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }

        /*pre_str is condition of where(query), str is keyword for update*/
        public void Update_team(string pre_str, string str)
        {
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "UPDATE team SET team_name = '" + str + "' WHERE team_name = '" + pre_str + "'";

            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }

        /*data is team_name, str is dpt_name*/
        public void Insert_team(string data, string str)
        {
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "INSERT INTO team(team_name, dpt_id) SELECT '" +data+ "', id FROM department WHERE dpt_name = '" +str+ "'";

            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }

        // Find Nodes by Textbox1.Text Function
        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
                TreeNode node = null;
                while (StartNode != null)
                {
                    if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                    {
                        node = StartNode;
                        break;
                    };
                    if (StartNode.Nodes.Count != 0)
                    {
                        node = SearchNode(SearchText, StartNode.Nodes[0]);  //Recursive Search
                        if (node != null)
                        {
                            break;
                        };
                    };
                    StartNode = StartNode.NextNode;
                };
                return node;
        }

        /*'검색'Button Click Event*/
		private void button_Dpt_Search_Click(object sender, EventArgs e)
		{
            Visible_Init_Team_Add();
            Visible_Init_Team_Update();
            Visible_Init_Dpt_Add();
            string keyword = textBox1.Text;
            TreeNode SelectNode = SearchNode(keyword, treeView1.Nodes[0]);
            if(SelectNode !=null)
            {
                SelectNode.EnsureVisible(); //Expand the node
                
                DataTable dt = new DataTable();
                if (SelectNode.Parent == null)
                {
                    textBox2.Text = SelectNode.Text;
                    search_data(SelectNode.Text, dt);
                }
                else 
                {
                    textBox2.Text = SelectNode.Parent.Text;
                    search_data(SelectNode.Parent.Text, dt);
                }
            }
            
            
        }

        /*init of '팀 수정'Button*/
        private void Visible_Init_Team_Update()
        {
            Visible_Init_Team_Add();
            button5.Visible = false;
            button4.Text = "팀 수정";
            button6.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
        }

        /*init of '팀 추가'Button*/
        private void Visible_Init_Team_Add()
        {
            button2.Text = "팀 추가";
            label4.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
        }

        /*init of '부서 추가'Button*/
        private void Visible_Init_Dpt_Add()
        {
            button_Dpt_Udt.Text = "부서 수정";
            button3.Visible = false;
            textBox2.Enabled = false;
        }

        /*Click the '팀 수정'Button*/
        private void Visible_Click_Team_Update()
        {
            Visible_Init_Team_Add();
            button6.Visible = true;
            textBox3.Visible = true;
            button4.Text = "수정 취소";
            label4.Visible = false;
            button5.Visible = false;
        }

        /*Click the '팀 추가'Button*/
        private void Visible_Click_Team_Add()
        {
            Visible_Init_Team_Update();
            button2.Text = "취소";
            label4.Visible = true;
            textBox3.Visible = true;
            button5.Visible = true;
        }

        /*Click the '부서 추가'Button*/
        private void Visible_Click_Dpt_Add()
        {
            textBox2.Enabled = true;
            button3.Visible = true;
            button_Dpt_Udt.Text = "수정 취소";
        }

        /*label text changed*/
        private void label2_Click(object sender, EventArgs e)
        {
            if(label2.Text == "확장")
            {
                treeView1.ExpandAll();
                label2.Text = "축소";
            }
            else if(label2.Text == "축소")
            {
                treeView1.CollapseAll();
                label2.Text = "확장";
            }
        }

        private void button_Dpt_Plus_Click(object sender, EventArgs e)
        {
            Visible_Init_Team_Update();
            Visible_Init_Team_Add();
            FormAdmin_Dpt_Plus frm = new FormAdmin_Dpt_Plus();
            frm.ShowDialog();
        }

        /*'갱신' button click event*/
        private void button1_Click(object sender, EventArgs e)
        {
            Visible_Init_Team_Add();
            Visible_Init_Team_Update();
            Visible_Init_Dpt_Add();
            search_treeview();
        }

        /*After Find team data for that department, Add to dataGridView*/
        public void search_data(string str, DataTable table)
        {
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "SELECT team_name FROM s5469698.team WHERE dpt_id = (SELECT id FROM department where dpt_name = '" + str + "');";
            int count = 1;
            table.Columns.Add("번호");
            table.Columns.Add("팀명");

            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    table.Rows.Add(count, rdr[0]);
                    dataGridView1.DataSource = table;
                    count++;
                }
            }
        }

        /*treeview data click event*/
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //최상위 노드일 경우에만
            if(treeView1.SelectedNode.Parent == null) 
            {
                Visible_Init_Team_Add();
                Visible_Init_Team_Update();
                Visible_Init_Dpt_Add();
                textBox2.Text = treeView1.SelectedNode.Text; //하위 팀노드 클릭 시 부서명에 팀명도 들어가는 버그 수정필요
                dataGridView1.DataSource = null;
                DataTable table = new DataTable();
                string keyword = textBox2.Text;

                search_data(keyword, table);
            }
        }

       /*UI change for department update*/
        private void button_Dpt_Udt_Click(object sender, EventArgs e)
        {
            Visible_Init_Team_Add();
            Visible_Init_Team_Update();
            pre_str = textBox2.Text;
            if(textBox2.Text == "")
            {
                MessageBox.Show("부서를 선택해주세요.");
                return;
            }
            if(button_Dpt_Udt.Text == "부서 수정")
            {
                Visible_Click_Dpt_Add();
            }
            else
            {
                Visible_Init_Dpt_Add();
                textBox2.Text = treeView1.SelectedNode.Text;
            }
        }

        /*'수정완료' Button click event*/
        private void button3_Click(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                string keyword = textBox2.Text;
                Update_dpt(pre_str, keyword);
                MessageBox.Show("수정 완료!");
                Visible_Init_Dpt_Add();
            }
        }

        /*'팀 추가' Button click event*/
        private void button2_Click(object sender, EventArgs e)
        {
            Visible_Init_Dpt_Add();
            if(textBox2.Text == "")
            {
                MessageBox.Show("부서를 선택해주세요.");
                return;
            }
            if(button2.Text == "팀 추가")
            {
                Visible_Click_Team_Add();
            }
            else
            {
                Visible_Init_Team_Add();
            }
        }

        /*'등록' Button click event*/
        private void button5_Click(object sender, EventArgs e)
        {
            string data = textBox3.Text; //Team
            string keyword = textBox2.Text; //Department
            Insert_team(data, keyword);
            MessageBox.Show(data + " 등록 완료!");

            DataTable table = new DataTable();
            search_data(keyword, table);
            Visible_Init_Team_Add();
            textBox3.Text = "";
        }

        /*'팀 수정' Button click event*/
        private void button4_Click(object sender, EventArgs e)
        {
            Visible_Init_Dpt_Add();
            if (dataGridView1.CurrentCell == null)
            { 
                MessageBox.Show("선택된 팀이 없습니다.");
                return;
            }
            if (button4.Text == "팀 수정")
            {
                Visible_Click_Team_Update();
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string data = row.Cells[1].Value.ToString();
                textBox3.Text = data;
            }
            else
            {
                Visible_Init_Team_Update();
            }
        }


        private void 부서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			Point tempPoint = this.Location;
			FormAdmin_Dpt formDpt = new FormAdmin_Dpt();
			formDpt.Location = tempPoint;
			formDpt.Owner = this;
			formDpt.Show();
		}

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Hide();
			Point tempPoint = this.Location;
			FormAdmin_User formUser = new FormAdmin_User();
			formUser.Location = tempPoint;
			formUser.Owner = this;
			formUser.Show();
		}

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그 아웃");

			this.Hide();
			Point tempPoint = this.Location;
			Form_Login formLogin = new Form_Login();
			formLogin.Location = tempPoint;
			formLogin.Owner = this;
			formLogin.Show();
		}

        /*'수정완료'Button Click Event*/
        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string data = row.Cells[1].Value.ToString(); //origin
            string keyword = textBox3.Text; //new

            Update_team(data, keyword);
            MessageBox.Show("수정완료!");

            DataTable table = new DataTable();
            search_data(textBox2.Text, table);
            Visible_Init_Team_Update();
        }

    }
}