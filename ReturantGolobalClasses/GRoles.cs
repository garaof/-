using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolobalClasses
{
    public  class GRoles
    {
        public  int RoleID { get; set; }
        public  string RoleName { get; set; }
        public  GRoles()
        {
            RoleID = -1;
            RoleName = string.Empty;
        }
    }
}
