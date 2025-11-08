using DataAccess;
using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public  class BLAdditionalServices
    {
        public static bool UpdateAdditionalServices(GAdditionalServices S)
        {
            
            return DAAdditionalServices.UpdateAdditionalServices(S);    

        }

        public static GAdditionalServices GetAdditionalServices()
        {
            return DAAdditionalServices.GetAdditionalServices();
        }
    }
}
