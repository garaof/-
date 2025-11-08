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
    public  class BLPeople
    {
        public static DataTable GetAllPeopleList()
        {
           return DAPeople.GetAllPeopleList();  
        }
        public static GolobalClasses.GPerson FindPersonWithID(int ID)
        {
            return DAPeople.FindPersonWithID(ID);

        }

        public static int AddNewPerson(GPerson P)
        {
            return DAPeople.AddNewPerson(P);    
        }

        //Delete Person Using PersonID : 
        public static bool DeletePerson(int ID)
        {
            return DAPeople.DeletePerson(ID);
        }

        public static bool UpdatePerson(GPerson P)
        {
            return DAPeople.UpdatePerson(P);
        }
        public static bool IsPersonExist(int ID)
        {

            return DAPeople.IsPersonExist(ID);  
        }
    }
}
