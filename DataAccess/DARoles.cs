using GolobalClasses;
using System.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static  class DARoles
    {
        public static GRoles FindUserRoleWithID(int ID)
        {
            string query = @"select * from RolesTb where RoleID = @ID ";

            using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring)) 
                using (SqlCommand Command = new SqlCommand( query, Connection))
            {
                Command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                try
                {
                    Connection.Open();
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GRoles
                            {
                                RoleID = Convert.ToInt32(reader["RoleID"]),
                                RoleName = reader["RoleName"]?.ToString()

                            };
                        }
                        else
                        {
                            return null; 
                        }
                        
                    }
                }
                catch (Exception Ex)
                {
                    Logger.Log(Ex.Message);
                    return null; 
                }
            }
        }


        public static GRoles FindUserRoleWithName(string RoleName)
        {
            string query = @"select * from RolesTb where RoleName= @RoleName";

            using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
            using (SqlCommand Command = new SqlCommand(query, Connection))
            {
                Command.Parameters.Add("@RoleName", SqlDbType.NVarChar).Value = RoleName;
                try
                {
                    Connection.Open();
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            return new GRoles
                            {
                                RoleID = Convert.ToInt32(reader["RoleID"]),
                                RoleName = reader["RoleName"]?.ToString()

                            };
                        }
                        else
                        {
                            return null;
                        }

                    }
                }
                catch (Exception Ex)
                {
                    Logger.Log(Ex.Message);
                    return null;
                }
            }
        } 

        public static List<string> GetAllRoles()
        {
            List <string> roles = new List<string>();   

            string query = @"select RoleName from RolesTb"; 
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand Command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                          string   RoleName = Convert.ToString(reader["RoleName"]);
                            

                            roles.Add(RoleName);
                        }
                        return roles;

                    }




                }
            }catch (Exception Ex)
            {
                Logger.Log(Ex.Message); 
                return new List<string> ();    
            }  
        }





       

    }
}
