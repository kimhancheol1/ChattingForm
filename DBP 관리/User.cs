using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace DBP_관리
{
    internal class User
    {
        public string userName { get; set; }
        public string userID { get; set; }

        public User(string name, string userID)
        {
            this.userName = name;
            this.userID = userID;
        }

    }
}
