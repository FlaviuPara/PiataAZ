using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class User
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string salary { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string username { get; set; }

        public User(string id, string first_name, string last_name, string salary, string phone_number, string email, string username)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.salary = salary;
            this.phone_number = phone_number;
            this.email = email;
            this.username = username;
        }
    }
}
