using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILP
{
    class Request
    {
        public int id { get; set; }

        private string username, operation, result;
        public string Username 
        { 
            get { return username; }
            set { username = value; }
        }
        public string Operation 
        { 
            get { return operation; }
            set { operation = value; }
        }
        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        public Request() { }
        public Request(string username, string operation, string result)
        {
            this.username = username;
            this.operation = operation;
            this.result = result; 
        }
    }
}
