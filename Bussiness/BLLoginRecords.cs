using DataAccess;
using GolobalClasses;
using ReturantGolobalClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public  class BLLoginRecords
    {
        public static int InsertNewLoginRecord(GLoginRecords loginRecord)
        {
            return DALoginRecords.InsertNewLoginRecord(loginRecord);

        }

        public static DateTime? GetLoginTimeByIdSession(int sessionid)
        {
            return DALoginRecords.GetLoginTimeByIdSession(sessionid);
        }
        public static bool UpdateLoginRecord(int sessionid, DateTime LogoutDateTime, int sessionduration)
        {
            return DALoginRecords.UpdateLoginRecord(sessionid,LogoutDateTime,sessionduration);
        }

    }
}
