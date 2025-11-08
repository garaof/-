using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess
{
    public static  class DAUser
    {


        public static DataTable GetAllUserDetails()
        {
            DataTable dt = new DataTable();
            string query = @"
                        Select UsersTb.UserID ,UsersTb.UserName ,PeopleTb.FirstName ,PeopleTb.LastName,PeopleTb.JobTitle,RolesTb.RoleName,UsersTb.IsActive
                        from UsersTb inner join PeopleTb 
                        on UsersTb.PersonID =PeopleTb.PersonID 
                        inner join RolesTb on UsersTb.RoleID =RolesTb.RoleID 
                        where UsersTb.IsDeleted=0
                        ";
            try
            {
                using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {

                    Connection.Open();
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {

                        dt.Load(reader);

                    }

                    return dt;

                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message); 
                return dt;
            }
        }
        public static GUser FindUserByUserID(int userid) 
        {
            string query = @"select * from UsersTb where UserID = @ID";
            try
            {
                using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = userid;

                    Connection.Open();
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {


                        if (reader.Read())
                        {
                            return new GUser()
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                UserName = reader["UserName"].ToString(),
                                Password = reader["PassWord"].ToString(), 
                                Person = DAPeople.FindPersonWithID(Convert.ToInt32(reader["PersonID"])),
                                Role = DARoles.FindUserRoleWithID(Convert.ToInt32(reader["RoleID"])),
                                IsActive = Convert.ToBoolean(reader["IsActive"])

                            };
                        }
                        else
                        {
                            return null;
                        }
                    }

                }


            }
            
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return null;
            }
            

        } 
        public static bool UpdateUser(GUser User)
        {
            int rowsAffected = -1; 
            string query = @"update UsersTb 
                           set UserName= @UserName ,
	                           PassWord= @PassWord ,
	                           RoleID= @RoleID ,
	                           IsActive= @IsActive
	                           where UserID= @UserID "; 
            try
            {
                using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = User.UserName;
                    Command.Parameters.Add("@PassWord", SqlDbType.NVarChar).Value = User.Password;
                    Command.Parameters.Add("@RoleID", SqlDbType.Int).Value = User.Role.RoleID;
                    Command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = User.IsActive;
                    Command.Parameters.Add("@UserID", SqlDbType.Int).Value = User.UserID;
                    
                        Connection.Open();
                        rowsAffected = Command.ExecuteNonQuery();
                        return rowsAffected > 0;

                    
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return false;
            }

            
        }
        public static bool DeleteUserByUserID(int UserID) 
        {
            string query = @"Update UsersTb 
                       Set IsDeleted=1 ,
					   IsActive =0 
					   where UsersTb.UserID= @ID "; 
            try
            {
                using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = UserID;

                    
                        Connection.Open();
                        return Command.ExecuteNonQuery() > 0;

                    
                    
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return false;
            }

        }
        public static bool IsUserExists(int userid)
        {
            string query = @"select 1 from UsersTb where UserID = @ID"; 
            try
            {
                using (SqlConnection Connection = new SqlConnection((Settings.Connectionstring)))
                    using (SqlCommand Command = new SqlCommand( query, Connection))
                {
                    Command.Parameters.Add("@ID" ,SqlDbType.Int).Value=userid;
                    Connection.Open();  

                    object result = Command.ExecuteScalar(); 

                    return result != null;  
                }

            } catch (Exception ex)
            {
                Logger.Log(ex.Message);  
                return false;   
            }
        }  




        //if returns : 0 => user is not Active : 1=>user IS Active : -1 : UserIsNOtExists
        public static short  FindUserActivationByUserNameAndPassWord(string username, string password)
        {
            string query = @" select IsActive from UsersTb
                              where (UserName = @UserName and PassWord = @PassWord)
                              and  IsDeleted=0;";
            try
            {
                using (SqlConnection Connection = new SqlConnection((Settings.Connectionstring)))
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.Add("@UserName" ,SqlDbType.NVarChar).Value=username;
                    Command.Parameters.Add("@PassWord" ,SqlDbType.NVarChar).Value= password;    
                    Connection.Open();

                    object result = Command.ExecuteScalar();
                    if(result !=null && result != DBNull.Value)
                    {
                        return Convert.ToInt16(result);

                    }
                    else
                    {
                        return -1;
                    }
                }

            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return -1;
            }
        }

        public static GUser GetLoggedInUser(string userName,string Password)
        {
            string query = @"select UserID ,UserName ,PersonID,RoleID ,IsActive from UsersTb 
                             where (UserName= @UserName and PassWord= @PassWord)
                              and IsDeleted= 0 ;"; 
            try
            {
                using(SqlConnection connection = new SqlConnection((Settings.Connectionstring)))
                using (SqlCommand Command = new SqlCommand(query, connection))
                {
                    Command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName;
                    Command.Parameters.Add("@PassWord", SqlDbType.NVarChar).Value = Password;

                    connection.Open();
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GUser()
                            {
                                UserName = userName,
                                Password = "Hiden",
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Person = DAPeople.FindPersonWithID(Convert.ToInt32(reader["PersonID"])),
                                Role = DARoles.FindUserRoleWithID(Convert.ToInt32(reader["RoleID"])),
                                IsActive = Convert.ToBoolean(reader["IsActive"])

                            };
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return null;    
            }
        }   

        public static bool IsThereAnotherUserWithUserName(string username)
        {
            string query = @"select Count(*) from UsersTb where UserName= @UserName ";
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = username;


                    connection.Open();

                    object result = command.ExecuteScalar();
                    int resultasnumber = Convert.ToInt32(result); 
                    return resultasnumber > 0;  
                }

            } catch (Exception ex)
            {
                Logger.Log(ex.Message); 
                return false;   
            } 
        }

        public static int AddNewUser(GUser U)
        {
            string query = @"insert into UsersTb (UserName,PassWord,PersonID,RoleID,IsActive) 
                 Values( @UserName , @PassWord , @PersonID , @RoleID , @IsActive ); 
				 select SCOPE_IDENTITY(); "; 
            try 
            { 
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))  
                    using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = U.UserName;
                    command.Parameters.Add("@PassWord", SqlDbType.NVarChar).Value = U.Password;
                    command.Parameters.Add("@PersonID", SqlDbType.Int).Value = U.Person.PersonID;
                    command.Parameters.Add("@RoleID", SqlDbType.Int).Value = U.Role.RoleID;
                    command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = U.IsActive;


                    connection.Open();
                    object result = command.ExecuteScalar(); 
                    if(result != null && int.TryParse(result.ToString() , out int resultasnumber))
                    {
                        return resultasnumber; 
                    } else
                    {
                        return -1; 
                    }

                }
            } catch(Exception e)
            {
                Logger.Log(e.Message);  
                return -1;   
            } 
        }
        public static short? FindRoleIDByUserID(int userid)
        {
            string query = @"select  RoleID from UsersTb where UserID= @UserID ";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = userid; 


                    connection.Open();
                    object result = command.ExecuteScalar(); 
                    if(result ==null || result==DBNull.Value)
                    {
                        return null; 
                    }
                    else
                    {
                        return Convert.ToInt16(result);
                    } 

                }
            } catch (Exception e)
            {
                Logger.Log(e.Message);  
                return null;    
            }

        }

    }
}
