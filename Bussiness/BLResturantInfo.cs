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
    public  class BLResturantInfo
    {
        public static GResturantInfo GetResturantInfo()
        {
            return DAResturantInfo.GetResturantInfo();
        }



        public static bool UpdateResturantInfo(GResturantInfo resturantInfo)
        {

            return DAResturantInfo.UpdateResturantInfo(resturantInfo);
        } 




    }
}
