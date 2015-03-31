using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Admin : User
    {
        public Admin(string id, string first_name, string last_name, string salary, string phone_number, string email, string username) : base(id, first_name, last_name, salary, phone_number, email, username)
        {
        }
    }
}
