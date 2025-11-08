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
    public  class BLUser
    {
        public static DataTable GetAllUserDetails()
        {
            
            return DAUser.GetAllUserDetails();
        }
        public static GUser FindUserByUserID(int userid)
        {
            return DAUser.FindUserByUserID(userid);


        }
        public static bool UpdateUser(GUser User)
        {
           return DAUser.UpdateUser(User); 

        }
        public static bool DeleteUserByUserID(int UserID)
        {
            return DAUser.DeleteUserByUserID (UserID);

        }
        public static bool IsUserExists(int userid)
        {
            return DAUser.IsUserExists(userid);
        }

        public static short FindUserActivationByUserNameAndPassWord(string username, string password)
        {
           return DAUser.FindUserActivationByUserNameAndPassWord(username, password);

        }


        public static GUser GetLoggedInUser(string userName, string Password)
        { 
            return DAUser.GetLoggedInUser(userName, Password);
        }

        public static bool IsThereAnotherUserWithUserName(string username)
        {
           return DAUser.IsThereAnotherUserWithUserName (username);    
        }

        public static int AddNewUser(GUser U)
        {
            return DAUser.AddNewUser(U);
        }

        public static short? FindRoleIDByUserID(int userid)
        {
            return DAUser.FindRoleIDByUserID (userid);   

        } 




    }
}
