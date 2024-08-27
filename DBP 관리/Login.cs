using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Sockets;

namespace DBP_관리
{
    internal class Login
    {
        // 로그인 기능
        public void OnLogin(string id, string pass, int auto_info, int auto_login, string ip, Form_Login fLogin)
        {
            using (MySqlConnection conn = new MySqlConnection(LoginManager.code))
            {
                conn.Open();

                // 로그인 시 WHERE문으로 아이디를 확인, 비밀번호는 바로 암호화해서 동일한 암호화한 데이터 확인
                string query = $"SELECT ID, USER_id, USER_password FROM USER WHERE USER_id = '{id}' AND USER_password = (select hex(aes_encrypt('{pass}', SHA2('abcabc', 256))))";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 데이터가 존재할 경우 일치하다고 판단하고 로그인
                if (reader.HasRows)
                {
                    reader.Close();
                    // 아이디 확인
                    string logquery = $"insert into Login_log (user_id, log_time, log_type) " +
                        $"values ((select ID from USER where USER_id = '{id}'), '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}', 'in')";
                    cmd.CommandText = logquery;
                    cmd.ExecuteNonQuery();

                    // 버튼 체크 업데이트
                    logquery = $"update USER set auto_info = {auto_info}, auto_login = {auto_login}, ip = '{ip}' where USER_id = '{id}'";
                    cmd.CommandText = logquery;
                    cmd.ExecuteNonQuery();

                    Point temp = fLogin.Location;

                    fLogin.Hide();

                    Form_main main = new Form_main(id);
                    main.Location = temp;
                    main.Owner = fLogin;
                    main.Show();
                }
                // 데이터가 존재하지 않을 경우 아이디 또는 비밀번호가 일치하지 않음
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.");
                    reader.Close();
                    return;
                }
                conn.Close();
            }
        }

        // 관리자 로그인용
        public void OnLogin(string id, string pass, FormAdmin_Login Alogin)
        {
            using (MySqlConnection conn = new MySqlConnection(LoginManager.code))
            {
                conn.Open();

                string query = $"SELECT * FROM Admin WHERE Admin_ID = '{id}' AND Admin_PW = (select hex(aes_encrypt('{pass}', SHA2('abcabc', 256))))";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 데이터가 존재할 경우 일치하다고 판단하고 로그인
                if (reader.HasRows)
                {
                    Point temp = Alogin.Location;

                    Alogin.Hide();
                    FormAdmin_Dpt frm = new FormAdmin_Dpt();
                    frm.Location = temp;
                    frm.Owner = Alogin;
                    frm.Show();
                }
                // 데이터가 존재하지 않을 경우 아이디 또는 비밀번호가 일치하지 않음
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.");
                    reader.Close();
                    return;
                }
                conn.Close();
            }
        }

        // 자동 로그인, 자동 ID/PWD 입력
        public void AutoBox(CheckBox info, CheckBox login, TextBox txt_Login, TextBox txt_Password, Form_Login fLogin)
        {
            using (MySqlConnection conn = new MySqlConnection(LoginManager.code))
            {
                conn.Open();
                int minfo = 0;
                int mlogin = 0;
                string query = $"select auto_info, auto_login from USER where ip = '{LoginManager.Instance.getIP()}'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // 체크 박스 체크 여부 판단
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        minfo = Convert.ToInt32(reader["auto_info"]);
                        mlogin = Convert.ToInt32(reader["auto_login"]);
                        info.Checked = Convert.ToBoolean(reader["auto_info"]);
                        login.Checked = Convert.ToBoolean(reader["auto_login"]);
                    }
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    return;
                }

                // hex(aes_encrypt('{pass}', SHA2('abcabc', 256)))
                reader.Close();

                // 유저 아이디와 비밀번호를 검색하는 쿼리
                query = $"select USER_id, cast(AES_DECRYPT(unhex(USER_password), sha2('abcabc', 256)) as char(100)) from USER where ip = '{LoginManager.Instance.getIP()}'";
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string log = "";
                    string pas = "";
                    reader.Read();

                    // mysql에서 AES로 암호화된 비밀번호를 복호화 하는 쿼리이다. 복호화 시 바이너리로 나올 데이터를 cast() 함수로 미리 값을 캐스팅해서 출력하는 쿼리이다.
                    log = reader["USER_id"].ToString();

                    // 최종적으로 복호화한 암호 출력
                    pas = reader["cast(AES_DECRYPT(unhex(USER_password), sha2('abcabc', 256)) as char(100))"].ToString();

                    Debug.WriteLine(log);
                    if (login.Checked)
                    {
                        fLogin.Hide();
                        fLogin.ShowInTaskbar = false;
                        OnLogin(log, pas, Convert.ToInt32(info.Checked), Convert.ToInt32(login.Checked), LoginManager.Instance.getIP(), fLogin);
                    }

                    // 자동 아이디, 비밀번호 정보 입력
                    if (info.Checked)
                    {
                        txt_Login.Text = log;
                        txt_Password.Text = pas;
                    }
                }
                else
                {
                    return;
                }
                reader.Close();

                conn.Close();
            }
        }
    }
}
