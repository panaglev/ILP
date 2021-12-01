using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILP
{
    class User
    {
        public int id { get; set; }

        private string login, hash;
        public string Login 
        { 
            get { return login; }
            set { login = value; }
        }
        public string Hash 
        { 
            get { return hash; }
            set { hash = value; }
        }
        public User() { }
        public User(string login, string hash) 
        {
            this.login = login;
            this.hash = hash;
        }
    }
}
