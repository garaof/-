using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolobalClasses;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace DataAccess
{

    public class DAPeople
    {
        public static DataTable GetAllPeopleList()
        { 
            DataTable dt = new DataTable(); 
            string query = @"select * from PeopleTb";
            using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
            using (SqlCommand Command = new SqlCommand(query, Connection))
            {
                try
                {
                    Connection.Open();
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {
                        
                            dt.Load(reader);
                        
                    }

                }
                catch (Exception ex) {
                    Logger.Log(ex.Message);
                    return dt; 
                }
            }

            return dt;

        }
        public static  GolobalClasses.GPerson FindPersonWithID(int ID)
        {
            GPerson person = null;
            //To Prevent Returning UnCompelete Person Object : 
            bool IsFound = false; 
            string query = @"select * from PeopleTb where PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(GolobalClasses.Settings.Connectionstring))

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@PersonID",SqlDbType.Int).Value=ID;
                try
                {
                    connection.Open();
                    using (SqlDataReader Reader = command.ExecuteReader())
                    {

                        if (Reader.Read())
                        {

                            person = new GPerson()
                            {
                                PersonID = (int)Reader["PersonID"],
                                FirstName = Reader["FirstName"]?.ToString(),
                                LastName = Reader["LastName"]?.ToString(),
                                Phone = Reader["Phone"]?.ToString(),
                                Email = Reader["Email"]?.ToString(),
                                Address = Reader["Address"]?.ToString(),
                                JobTitle = Reader["JobTitle"]?.ToString()
                            };

                            IsFound = true;
                        }



                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                    return null;
                }
                

            }
            return IsFound ? person : null;
             
        }

        public static int  AddNewPerson(GPerson P)
        { 
            int AddedID=-1;
            if (P == null) { return AddedID; } 


            string query = @"insert into PeopleTb (FirstName,LastName,Phone,Email,Address,JobTitle) 
                             Values( @FirstName , @LastName , @Phone , @Email , @Address , @JobTitle) 
                               select  scope_Identity() ;";

            //Opening Connecion : 
            using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
            using (SqlCommand Command = new SqlCommand(query, Connection))
            {
                Command.Parameters.Add("@FirstName", SqlDbType.NVarChar,20).Value = P.FirstName;
                Command.Parameters.Add("@LastName" ,SqlDbType.NVarChar,25).Value= P.LastName;
                Command.Parameters.Add("@Phone", SqlDbType.NVarChar,20).Value = P.Phone; 
                Command.Parameters.Add("@Email" ,SqlDbType.NVarChar,50).Value=P.Email;
                Command.Parameters.Add("@Address", SqlDbType.NVarChar,200).Value = P.Address;
                Command.Parameters.Add("@JobTitle", SqlDbType.NVarChar,100).Value = P.JobTitle; 
                try
                {
                    Connection.Open();
                    
                    object Result = Command.ExecuteScalar();

                    if(Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    {
                        AddedID = InsertedID;
                    } 


                }
                catch (Exception Ex)
                {
                    Logger.Log(Ex.Message);
                    return AddedID; 
                }

            } 

            return AddedID;  
        }

        //Delete Person Using PersonID : 
        public static bool DeletePerson(int ID)
        {
            int RowsAffected = -1; 
            string query = @"Delete from PeopleTb where PersonID = @ID"; 

            using(SqlConnection Connection = new SqlConnection(Settings.Connectionstring)) 
            using (SqlCommand Command = new SqlCommand(query,Connection))
            {
                Command.Parameters.Add("@ID",SqlDbType.Int).Value = ID;
                
                try
                {
                    Connection.Open();
                    RowsAffected = Command.ExecuteNonQuery(); 


                } catch(Exception EX)
                {
                    Logger.Log(EX.Message);
                    return false; 
                }
            } 
            return RowsAffected > 0; 
        }
         
        public static bool UpdatePerson(GPerson P)
        {
            int RowsAffected = -1;

            string query = @"update PeopleTb 
                             set FirstName= @FirstName ,
                                 LastName= @LastName ,
	                             Phone= @Phone ,
	                             Email = @Email ,
	                             Address = @Address ,
	                             JobTitle= @JobTitle 
	                             where PersonID= @PersonID " ; 

            using(SqlConnection Connection =new SqlConnection(Settings.Connectionstring))
                using (SqlCommand Command =new SqlCommand(query, Connection))
            {
                Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = P.FirstName;
                Command.Parameters.Add("@LastName", SqlDbType.NVarChar, 25).Value = P.LastName;
                Command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = P.Phone;
                Command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = P.Email;
                Command.Parameters.Add("@Address", SqlDbType.NVarChar, 200).Value = P.Address;
                Command.Parameters.Add("@JobTitle", SqlDbType.NVarChar, 100).Value = P.JobTitle;
                Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = P.PersonID;


                try
                {
                    Connection.Open();
                    RowsAffected = Command.ExecuteNonQuery();

                }
                catch(Exception ex)
                {
                    Logger.Log(ex.Message);
                    return false;   
                } 

            }
            return RowsAffected > 0; 
        }
        public static bool IsPersonExist(int ID ) 
        {
            
            string query = "select 1 from  PeopleTb where PersonID = @ID";

            using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
                using(SqlCommand Command = new SqlCommand(query,Connection))
            {
                Command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                try
                {
                    Connection.Open();
                   return Command.ExecuteScalar() != null; 
                    
                } catch(Exception ex)
                {
                    Logger.Log(ex.Message);
                    return false; 
                }
            } 
             
        
        }

    }
}
