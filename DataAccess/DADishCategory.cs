using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolobalClasses;
using System.Data; 

namespace DataAccess
{
    public  class DADishCategory
    {
        public static GDishCategory GetDishCategoryByID(int categoryid)
        {
            string query = @"select  CategoryName from DishCategoriesTb where CategoryID = @ID ";

            try
            {
                using(SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.Add("@ID", SqlDbType.Int).Value = categoryid;

                    Connection.Open();
                    object reader = Command.ExecuteScalar();
                    if (reader != null)
                    {
                        return new GDishCategory()
                        {
                            ID = categoryid,
                            Name = reader.ToString()
                        }; 
                    }
                    else
                    {
                        return null;
                    }
                }
            }catch (Exception ex)
            {
                Logger.Log(ex.Message); 
                return null;    
            }
        } 
        public static List<string> GetAllDishCategories()
        {
            List<string> ListNames = new List<string>();
            string query = @"select  CategoryName  from DishCategoriesTb ";

            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                    using (SqlCommand Command = new SqlCommand(query, connection))
                {
                    connection.Open(); 
                    using(SqlDataReader reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Name = Convert.ToString(reader["CategoryName"]);
                            ListNames.Add(Name);    
                        } 

                        return ListNames;   
                         
                    } 
                }
            }catch(Exception ex) 
            {
                Logger.Log(ex.Message);
                return new List<string> ();    
            }
        }
        public static int GetCategoryIDCategoryByName(string cagtegoryname)
        {
            string query = @"select CategoryID from DishCategoriesTb where CategoryName= @Name ";

            try
            {
                using (SqlConnection Connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = cagtegoryname;

                    Connection.Open();
                    object reader = Command.ExecuteScalar();
                    if (reader != null && reader!=DBNull.Value)
                    {
                        return Convert.ToInt32(reader.ToString());  
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




    }
}
