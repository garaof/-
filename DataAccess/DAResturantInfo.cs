using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public  class DAResturantInfo
    { 
        //هذا الجدول يحتوي سطر واحد فقط يحتوي معلومات المطعم فقط 
        public static GResturantInfo GetResturantInfo()
        {
            string query = @"select * from ResturantInfoTb";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open(); 
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GResturantInfo()
                            {
                                ResturantName = Convert.ToString(reader["Resturantname"]),
                                ResturantAddress = Convert.ToString(reader["Address"]),
                                LogoPath =( reader["LogoPath"]== DBNull.Value) ? string.Empty:Convert.ToString(reader["LogoPath"]),
                                Slogan = (reader["Slogan"] == DBNull.Value) ? string.Empty : Convert.ToString(reader["Slogan"])
                            };
                        }
                        else
                        {
                            return null;    
                        }
                    }
                }
            }catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return null;    
            }
        }  

        public static bool UpdateResturantInfo(GResturantInfo resturantInfo)
        {
            if (resturantInfo == null)
            {
                return false;   
            } 
            string query = @"update ResturantInfoTb
                             set Resturantname = @Name ,
			                 Address= @Address ,
			                 LogoPath= @Path ,
			                 Slogan= @Slogan ;";
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))  
                    using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = resturantInfo.ResturantName;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = resturantInfo.ResturantAddress;
                    command.Parameters.Add("@Path", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(resturantInfo.LogoPath) ? DBNull.Value : (object) resturantInfo.LogoPath;
                    command.Parameters.Add("@Slogan", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(resturantInfo.Slogan) ? DBNull.Value : (object) resturantInfo.Slogan;

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;


                }
            } catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return false;   
            }


        }

    }
}
