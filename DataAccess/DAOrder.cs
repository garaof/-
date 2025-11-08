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
     public  class DAOrder
    { 
        public static GOrder GetOrderByID(int id)
        {
            string query = @"select * from OrdersTb where OrderID = @ID" ;

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GOrder()
                            {
                                OrderID = Convert.ToInt32(reader["OrderID"]),
                                EatIn = Convert.ToBoolean(reader["EatIn"]),


                                TableNumber = reader["TableNumber"] == DBNull.Value ? -1 : Convert.ToInt32(reader["TableNumber"])

                                ,
                                UserID = Convert.ToInt32(reader["UserID"]),
                                OrderDate =Convert.ToDateTime( reader["OrderDate"])
                            };
                        }
                        else
                        {
                            return null; 
                        }
                    }

                }
            } catch (Exception ex)
            {
                Logger.Log(ex.Message);  
                return null;    
            }
        } 

        public static int  AddNewOrder(GOrder newOrder)
        {
            string query = @"insert into OrdersTb (EatIn,TableNumber,UserID,OrderDate) 
                                            values ( @EatIn , @TableNumber , @UserID , @OrderDate)
                                             Select Scope_Identity()  "; 
            
            
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@EatIn", SqlDbType.Bit).Value = newOrder.EatIn;
                    if(newOrder.TableNumber > 0)
                    {
                        command.Parameters.Add("@TableNumber", SqlDbType.Int).Value = newOrder.TableNumber;

                    }
                    else
                    {
                        command.Parameters.Add("@TableNumber", SqlDbType.Int).Value = DBNull.Value;

                    }
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = newOrder.UserID;
                    command.Parameters.Add("@OrderDate",SqlDbType.SmallDateTime).Value= newOrder.OrderDate; 

                    connection.Open();
                    object result = command.ExecuteScalar(); 
                    if(result != null && int.TryParse(result.ToString() ,out int InsertedID ))
                    {
                        return InsertedID;  
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

        



    }
}
