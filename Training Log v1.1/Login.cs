using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Training_Log_v1._1
{
    class Login
    {
        private string userName;
        private string password;

        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;

        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
