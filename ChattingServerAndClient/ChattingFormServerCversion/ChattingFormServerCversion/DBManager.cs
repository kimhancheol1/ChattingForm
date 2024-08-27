using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattingFormServerCversion
{
    internal class DBManager
    {
        private static DBManager instance = new DBManager();

        public static DBManager GetInstance()//자기 자신의 인스턴스를 외부에 제공
        {
            return instance;
        }

        private DBManager()
        {
            // .. Some initialization for this singleton object
        }

        public string RunQuery(string query)//쿼리를 실행하고 그 결과를 받아오는 함수
        {
            using (MySqlConnection connection = new MySqlConnection("Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;"))
            {
                string readerUse = "";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    readerUse += reader[0].ToString() + "";
                    
                }
                return readerUse;
            }
        }
        public string[] RunQueryArray(string query)//쿼리를 실행하고 그 결과를 받아오는 함수
        {
            using (MySqlConnection connection = new MySqlConnection("Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;"))
            {
                string readerUse = "";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    readerUse += reader[0].ToString()+",";
                }

                return readerUse.Split(',');
            }
        }
    }
}
