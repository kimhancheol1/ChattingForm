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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBP_관리 {
	public partial class FormAdmin_Dpt_Plus : Form {
		public FormAdmin_Dpt_Plus() {
			InitializeComponent();
		}

        /*str is dpt_name to add & Insert query*/
		public void INSERT_dpt(string str)
		{
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "INSERT into department(dpt_name) values('" +str + "')";

            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }

        /*str is dpt_name to search & Select query to check for duplicates*/
        public bool SELECT_dpt(string str)
		{
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
            string query = "SELECT dpt_name FROM department WHERE dpt_name = '" + str + "'";
            using (MySqlConnection connection = new MySqlConnection(Connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    MessageBox.Show("이미 존재하는 부서명입니다!");
                    return false;
                }
                return true;
            }
        }
        /*'추가'button click event*/
        private void button_Dpt_Plus_Click(object sender, EventArgs e)
        {
            string keyword = textBox_Dpt_Plus_Name.Text;
            if (SELECT_dpt(keyword) == true) //check for duplicates
            {
                INSERT_dpt(keyword);
                MessageBox.Show("해당 부서를 추가하였습니다!");
            }
            
			
		}
	}
}
