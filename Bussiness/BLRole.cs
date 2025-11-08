using DataAccess;
using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public  class BLRole
    {
        public static GRoles FindUserRoleWithID(int ID)
        {
           return DARoles.FindUserRoleWithID(ID); 
            
        }


        public static GRoles FindUserRoleWithName(string RoleName)
        {
            
            return DARoles.FindUserRoleWithName(RoleName);  
        }



        public static List<string> GetAllRoles()
        {
           return DARoles.GetAllRoles();
        }

    }
}
