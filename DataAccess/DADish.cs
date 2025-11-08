using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public  class DADish
    {
        public static DataTable GetAllDishesInMenue()
        {
            DataTable dt = new DataTable();
            string query = @"select DisheID ,Name ,Price,Description ,IsAvailable  ,CategoryName From DishesTb inner Join DishCategoriesTb  
                             on DishesTb.CategoryID=DishCategoriesTb.CategoryID 
							 Where DishesTb.IsDeleted=0";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring)) 
                    using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open(); 
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                        return dt;
                    }
                }
            }catch(Exception ex) 
            {
                Logger.Log(ex.Message); 
                return dt;  
            }

        } 

        public static DataTable GetAllDishesByCategoryID(int id )
        {
            DataTable dt = new DataTable();
            string query = @"select * from DishesTb where CategoryID = @id";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                { 
                    command.Parameters.Add("@id" ,SqlDbType.Int).Value=id;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return dt;
            }

        }
        
        public static GDish GetDishByID(int dishid)
        {
            string query = @"select * from DishesTb where DisheID= @dishid ";
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring)) 
                    using (SqlCommand command = new SqlCommand( query, connection))
                {
                    command.Parameters.Add("@dishid", SqlDbType.Int).Value = dishid;
                    connection.Open();  

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GDish()
                            {
                                DishID = dishid,
                                DishName = reader["Name"].ToString(),
                                DishPrice = Convert.ToDecimal(reader["Price"]),
                                ImagePath = reader["ImageLink"] != DBNull.Value ? reader["ImageLink"].ToString() : null ,
                                Description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : "There is No Description", 
                                IsAvailable = Convert.ToBoolean(reader["IsAvailable"]),
                                CategoryID =Convert.ToInt32(reader["CategoryID"]),

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
        public static int AddNewDish(GDish newdish)
        {
            string query = @"insert into DishesTb  (Name,Price,ImageLink,Description,IsAvailable,CategoryID,IsDeleted) 
                                    Values( @DishName , @DishPrice , @ImageLink ,@Description , @IsAvailable , @CategoryID ,@IsDeleted ) 
                                    select SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                    using(SqlCommand command= new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@DishName", SqlDbType.NVarChar).Value = newdish.DishName;
                    command.Parameters.Add("@DishPrice", SqlDbType.Decimal).Value = newdish.DishPrice;
                    command.Parameters.Add("@ImageLink", SqlDbType.NVarChar).Value = string.IsNullOrWhiteSpace(newdish.ImagePath) ? DBNull.Value :(object) newdish.ImagePath;
                    command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = string.IsNullOrWhiteSpace( newdish.Description) ? DBNull.Value : (object) newdish.Description;
                    command.Parameters.Add("@IsAvailable", SqlDbType.Bit).Value = newdish.IsAvailable;
                    command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = newdish.CategoryID;
                    command.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = newdish.IsDeleted;

                    connection.Open();

                    object result = command.ExecuteScalar(); 
                    if (result != null  && int.TryParse(result.ToString(),out int insertedid))
                    {
                        return insertedid;
                    }
                    else
                    {
                        return -1;  
                    }
                }
            } catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return -1;  
            } 
        }

        public static bool UpdateDish(GDish dish)
        { 
            //make sure that there is no required fiels is not true : 

            if(string.IsNullOrEmpty(dish.DishName) || dish.DishID<=0 || dish.DishPrice<0 || dish.CategoryID <= 0){
                return false; 
            }

            int rowsAffected = -1 ; 
            string query = @"update DishesTb  set 
	                           Name = @Name  ,
							   Price= @Price ,
							   ImageLink= @ImageLink ,
							   Description= @Description ,
							   IsAvailable= @IsAvailable ,
							   CategoryID= @CategoryID 
							   where DisheID= @DishID "; 
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring)) 
                    using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Name",SqlDbType.NVarChar).Value= dish.DishName ;
                    var price = command.Parameters.Add("@Price", SqlDbType.Decimal);
                    price.Precision = 10;
                    price.Scale = 2;
                    price.Value=dish.DishPrice;
                    command.Parameters.Add("@ImageLink", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(dish.ImagePath) ? (object)DBNull.Value : dish.ImagePath;
                    command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(dish.Description) ? (object)DBNull.Value : dish.Description;
                    command.Parameters.Add("@IsAvailable", SqlDbType.Bit).Value = dish.IsAvailable;
                    command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = dish.CategoryID;
                    command.Parameters.Add("@DishID", SqlDbType.Int).Value = dish.DishID;


                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;


                }
            } catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return false;   
            }
        }
        public static string GetDishNameByDishID(int dishID)
        {
            string query = @"select Name  from DishesTb where DisheID = @ID";
            string dishname = string.Empty; 
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", dishID);

                    connection.Open();
                    object result = command.ExecuteScalar(); 

                    if (result != null)
                    {
                        return Convert.ToString(result);
                    }
                    else
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


        public static bool IsDishExists(int dishid)
        {
            string query = @"select 1  from DishesTb where DisheID = @ID "; 
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                    using(SqlCommand command =new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ID" ,SqlDbType.Int).Value=dishid;
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if(result != DBNull.Value && int.TryParse(result.ToString() ,out int one))
                    {
                        return one > 0;
                    }
                    else
                    {
                        return false;   
                    }
                }
                
            }catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return false;   
            }
        }

        public static bool DeleteDish(int ID)
        {
            string query = @"update DishesTb set IsDeleted=1 where DisheID= @ID ";
            int rowsAffected = -1; 
            try
            {
                using(SqlConnection connection =new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID; 
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }catch (Exception ex)
            {
                Logger.Log(ex.Message); 
                return false;   
            }
        }




    }
}
