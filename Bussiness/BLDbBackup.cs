using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Bussiness
{
    public  class BLDbBackup
    {
        public static bool MakeAcopyFromDB(string FileDestination)
        {
            return DADbBackup.MakeAcopyFromDB(FileDestination);  
        }


        public static bool RestoreDataBaseOldCopy(string FileName)
        {
            return DADbBackup.RestoreDataBaseOldCopy(FileName);
        }
    }
}
