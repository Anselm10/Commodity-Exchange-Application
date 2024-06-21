using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commodity_exchange_application
{
    public class Account
    {
        private string _username;
        private string _password;

        public Account() { }
        public Account (string name, string password) 
        {
            Name = name;
            Password = password;
        }

        public string Name { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
