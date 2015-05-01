using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Log_v1._1
{
    class Client
    {
        private string _userName;
        private string _userPassword;
        private int _id;
        private string _name;
        private string _address;
        private string _phone;
        private string _email;

        public Client(string userName, string userPassword, int id, string name, string address, string phone,
            string email)
        {
            _userName = userName;
            _userPassword = userPassword;
            _id = id;
            _name = name;
            _address = address;
            _phone = phone;
            _email = email;
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public override string ToString()
        {
            return UserName + '|' + UserPassword + '|' + ID + '|' + Name + '|' + Address + '|' + Phone + '|' + Email;
        }
    }
}
