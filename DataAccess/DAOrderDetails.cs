using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public  class DAOrderDetails
    { 
        //to return All Details Attached to one order : 
        public static List<GOrderDetailsRecord>  GetAllOrderDetailsByOrderID(int OrderID)
        {
            List<GOrderDetailsRecord> G=new List<GOrderDetailsRecord>();
            string query = @"select od.*,d.Name  from OrdersDetailsTb od inner join 
                             DishesTb d on d.DisheID =od.DishID 
                             where od.OrderID = @OrderID "; 
            
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrderID;
                    connection.Open(); 
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            GOrderDetailsRecord record = new GOrderDetailsRecord()
                            {
                                OrderDetailID = Convert.ToInt32(reader["OrderDetailID"]),
                                OrderID = Convert.ToInt32(reader["OrderID"]),
                                DishID = Convert.ToInt32(reader["DishID"]),
                                DishPrice = Convert.ToDecimal(reader["DishPrice"]),
                                Units = Convert.ToInt16(reader["Units"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                DishName = Convert.ToString(reader["Name"])
                            }; 
                            G.Add(record);  
                        } 
                        return G;  
                    }
                }
            } catch (Exception ex)
            {
                Logger.Log(ex.Message); 
                return null;   
            }
        }        

        //to Get Total Sales For Menu Items Between two Dates : 
        public static DataTable GetTotalSalesForDishes(DateTime StartDate ,DateTime EndDate)
        {
            DataTable dt = new DataTable();
            string query = @"select DishesTb.DisheID ,DishesTb.Name ,
                             TotalSales= sum(OrdersDetailsTb.Units) 
			                 from DishesTb inner join OrdersDetailsTb 
			                 on DishesTb.DisheID = OrdersDetailsTb.DishID 
			                 inner join OrdersTb  
			                 on OrdersTb.OrderID =OrdersDetailsTb.OrderID 
			                 where OrdersTb.OrderDate >= @StartDate 
			                 and OrdersTb.OrderDate < DateAdd(day,1, @EndDate) 
			                 Group by DishesTb.DisheID ,DishesTb.Name
			                 Order by TotalSales Desc";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@StartDate", SqlDbType.SmallDateTime).Value = StartDate;
                    command.Parameters.Add("@EndDate" ,SqlDbType.SmallDateTime).Value =EndDate; 
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

        public static GOrderDetailsRecord GetOrderDetailRecord(int ID)
        {
            string query = @"select * from OrdersDetailsTb where OrderDetailID= @ID";


            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GOrderDetailsRecord()
                            {
                                OrderDetailID = ID,
                                OrderID = Convert.ToInt32(reader["OrderID"]),
                                DishID = Convert.ToInt32(reader["DishID"]),
                                DishPrice = Convert.ToDecimal(reader["DishPrice"]),
                                Units = Convert.ToInt16(reader["Units"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                DishName = ""
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return null;    
            }
        }
            
        public static int AddNewOrderDetailRecord(GOrderDetailsRecord ODR)
        {
            string query = @"insert into OrdersDetailsTb (OrderID,DishID,DishPrice,Units,Total) 
                            Values ( @OrderID , @DishID , @DishPrice , @Units ,@Total ) 
	                        Select SCOPE_IDENTITY();"; 
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@OrderID", SqlDbType.Int).Value = ODR.OrderID;
                    command.Parameters.Add("@DishID", SqlDbType.Int).Value = ODR.DishID;
                    command.Parameters.Add("@DishPrice", SqlDbType.Decimal).Value = ODR.DishPrice;
                    command.Parameters.Add("@Units", SqlDbType.SmallInt).Value = ODR.Units;
                    command.Parameters.Add("@Total", SqlDbType.Decimal).Value = ODR.Total;

                    connection.Open();
                    object  result = Convert.ToInt32(command.ExecuteScalar());    
                    if(result != null && int.TryParse(result.ToString(), out int insertedid))
                    {
                        return insertedid;
                    }
                    else
                    {
                        return -1;   
                    }
                    
                     
                }
            } catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return -1;  
            }
        }


    }
}
