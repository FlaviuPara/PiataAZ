using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BL
{
    public class AddsServices
    {
        AddsDAL addsDAL = new AddsDAL();

        public void createAdd(Add add)
        {
            addsDAL.createAdd(add);
        }

        public Add readAdd(String id)
        {
            return addsDAL.readAdd(id);
        }

        public void updateAdd(Add add)
        {
            addsDAL.updateAdd(add);
        }

        public void deleteAdd(String id)
        {
            addsDAL.deleteAdd(id);
        }

        public int getNrOfAddsForUser(String username)
        {
            return addsDAL.getNrOfAddsForUser(username);
        }
    }
}
