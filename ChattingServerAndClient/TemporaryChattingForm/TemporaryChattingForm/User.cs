using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemporaryChattingForm
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
