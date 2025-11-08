using GolobalClasses;
using ReturantGolobalClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace DataAccess
{
    public  class DALoginRecords
    { 
        public static int  InsertNewLoginRecord(GLoginRecords loginRecord)
        {
            string query = @"insert into LoginRecordsTb (LoginDateTime,LogoutDatTime,SessionDuration,UserID) 
                                              Values( @LoginDate , @LogoutDate , @Duration , @UserID );
                                              select SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@LoginDate", SqlDbType.DateTime2).Value = loginRecord.LoginDateTime;
                    command.Parameters.Add("@LogoutDate", SqlDbType.DateTime2).Value = (object)loginRecord.LogoutDateTime   ?? DBNull.Value ;
                    command.Parameters.Add("@Duration", SqlDbType.Int).Value = (object) loginRecord.SessionDuration ?? DBNull.Value;
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = loginRecord.UserID;

                    connection.Open();

                    object   result = command.ExecuteScalar();
                    if(result != null && int.TryParse(result.ToString(),out int InsertedId))
                    {
                        return InsertedId;  
                    }
                    else
                    {
                        return -1;   
                    }


                }
            } catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return -1 ;   
            }
            
        }  
         
        public static DateTime? GetLoginTimeByIdSession(int sessionid)
        {
            string query = @"select LoginDateTime from LoginRecordsTb where LoginID= @ID";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = sessionid;

                    connection.Open(); 
                    object result = command.ExecuteScalar(); 

                    if(result != null && DateTime.TryParse(result.ToString() , out DateTime logindate))
                    {
                        return logindate;   
                    } else
                    {
                        return null;    
                    }
                }
            }catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return null;    
            }
        }

        public static bool UpdateLoginRecord(int sessionid ,DateTime LogoutDateTime ,int sessionduration)
        {
            string query = @"update LoginRecordsTb set LogoutDatTime= @LogoutDate ,SessionDuration= @SessionDuration where LoginID = @ID;"; 
            try
            {
                using(SqlConnection connection =new SqlConnection(Settings.Connectionstring)) 
                    using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@LogoutDate", SqlDbType.DateTime2).Value = LogoutDateTime;
                    command.Parameters.Add("@SessionDuration", SqlDbType.Int).Value = sessionduration;
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = sessionid; 

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            } catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return false;   
            }
        }
        

    }
}
