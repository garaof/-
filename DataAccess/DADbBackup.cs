using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolobalClasses;

namespace DataAccess
{
    public  class DADbBackup
    {
        public static bool MakeAcopyFromDB(string FileDestination)
        {
            string Query = $@"backup DataBase ResturantMDB to disk='{FileDestination}'";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    connection.Open(); 
                    command.ExecuteNonQuery();
                    return true;    

                }
            } catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return false;   
            }
        }    


        public static bool RestoreDataBaseOldCopy(string FileName)
        {
            string SingleUserQuery = @"Alter DataBase ResturantMDB set Single_User With rollback Immediate;";
            string MainQuery =     $@"
                                   Restore DataBase ResturantMDB from disk='{FileName}'
                                   With Replace;  
                                   ";
            string MultiUserQuery = @"Alter Database ResturantMDB set Multi_User;";
            //تبديل نص الاتصال الي قاعدة البيانات المركزية لمعالجة خطأ قاعدة البيانات قيد الاستخدام أثناء الاستعادة
            string RestoreString = Settings.Connectionstring.Replace("ResturantMDB","master");
            try
            {

                using (SqlConnection connection = new SqlConnection(RestoreString))
                {
                    connection.Open();
                    using (SqlCommand SingleUserCommand = new SqlCommand(SingleUserQuery, connection))
                    {
                        SingleUserCommand.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(MainQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    
                    return true;

                }



            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message); 
                return false;   
            }
            finally
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(RestoreString))
                    {
                        connection.Open();
                        using (SqlCommand MutliUsercommand = new SqlCommand(MultiUserQuery, connection))
                        {
                            MutliUsercommand.ExecuteNonQuery();
                        }
                    }
                    
                }catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                }
                
            }
        }
    }
}
