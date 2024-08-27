using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_관리
{
    public enum OutputSort
    {
        None,
        Department,
        Team,
    }

    internal class Regist
    {
        // 회원가입 기능 -> 회원가입 창에서 회원가입을 누를 시 데이터를 저장해주는 기능.
        public bool Resist(string profile, string name, string nick, string id,
            string pass, string zipcode, string landlord, string road, string department, string team, string date)
        {
            // 이미지 넣기 전 BLOB 형식에 넣을 수 있게 변환
            byte[] imageData = null;
            if (string.IsNullOrEmpty(profile))
            {
                MessageBox.Show("프로필 이미지를 넣어주세요");
                return false;
            }
 
            FileStream fs = new FileStream(profile, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)fs.Length);

            if (NullCheck(profile, name, nick, id, pass, landlord, department, team))
            {
                using (MySqlConnection conn = new MySqlConnection(LoginManager.code))
                {
                    conn.Open();
                    try
                    {
                        string query = $"INSERT INTO USER (USER_image, USER_name, USER_nickname, USER_id, USER_password, zipcode, USER_roadAddress, USER_landlordAddress, " +
                            $"department_id, team_id, USER_birth)" +
                            $"VALUES(@IMG, '{name}', '{nick}', '{id}', (select hex(aes_encrypt('{pass}', SHA2('abcabc', 256)))), {zipcode}, '{road}', '{landlord}', " +
                            $"(select id from department where dpt_name = '{department}'), " +
                            $"(select id from team where team_name = '{team}' and dpt_id = (select id from department where dpt_name = '{department}')), " +
                            $"'{date}')";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.Add(new MySqlParameter("@IMG", imageData));
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("회원가입이 완료되었습니다");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            else
                return false;

            return true;

        }

        /*
        // 닉네임 중복 확인
        public bool CheckRepetition(string id, Label label)
        {
            using (MySqlConnection conn = new MySqlConnection(LoginManager.code))
            {
                conn.Open();
                string query = $"SELELCT USER_nickname FROM USER where USER_id = '{id}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (label.Text == "") return false;
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    label.Text = "닉네임이 중복됩니다";
                    return false;

                }
                else
                {
                    reader.Close();
                    label.Text = "";
                    return true;

                }
                conn.Close();
                return true;
            }
        }*/


        // 아이디 중복 확인
        public bool CheckID(string check, string column, bool active)
        {
            using (MySqlConnection conn = new MySqlConnection(LoginManager.code))
            {
                conn.Open();
                string query = $"SELECT {column} FROM USER WHERE {column} = '{check}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 데이터가 중복하는 경우
                if (reader.HasRows)
                {
                    MessageBox.Show("해당 데이터는 중복됩니다.");
                    active = false;
                    return false;
                }
                else
                {
                    MessageBox.Show("사용 가능합니다.");
                    active = true;
                }
                reader.Close();
                conn.Close();
            }
            return true;
        }

        // 빈 칸 확인 기능
        private bool NullCheck(string profile, string name, string nickname, string id, string password,
            string address, string department, string team)
        {
            if (string.IsNullOrEmpty(profile))
            {
                MessageBox.Show("프로필 이미지를 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("이름을 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("닉네임을 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("아이디를 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("주소를 입력해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("부서를 설정해주세요");
                return false;
            }
            if (string.IsNullOrEmpty(team))
            {
                MessageBox.Show("팀을 선택해주세요");
                return false;
            }

            return true;
        }


        // 부서 및 팀 콤보 박스 데이터 출력
        public void LoadComboBoxColumnData(ComboBox department, ComboBox team, string column, string table, OutputSort sort = OutputSort.None)
        {
            string query = "";
            switch (sort)
            {
                case OutputSort.None:
                    break;
                case OutputSort.Department:
                    using (MySqlConnection conn = new MySqlConnection(LoginManager.code))
                    {
                        conn.Open();
                        query = $"select {column} from {table} order by dpt_name asc";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        department.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                department.Items.Add(reader[column].ToString());
                            }
                        }
                        else
                        {
                            reader.Close();
                            conn.Close();
                            return;
                        }
                        reader.Close();
                        conn.Close();
                    }
                    break;

                case OutputSort.Team:
                    using (MySqlConnection conn = new MySqlConnection(LoginManager.code))
                    {
                        conn.Open();
                        query = $"select {column} from {table} where dpt_id = (select id from department where dpt_name = '{department.Text}') order by team_name asc";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        team.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                team.Items.Add(reader[column].ToString());
                            }
                        }
                        else
                        {
                            reader.Close();
                            conn.Close();
                            return;
                        }
                        reader.Close();
                        conn.Close();
                    }
                    break;
            }
        }
    }
}
