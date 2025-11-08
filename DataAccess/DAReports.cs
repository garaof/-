using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Threading;

namespace DataAccess
{
    public class DAReports
    {
        public static DataTable GetTotalWorkPeriodForUsersByDate(DateTime date)
        {
            DataTable dt = new DataTable();
            string query = @"select UsersTb.UserName ,Sum(LoginRecordsTb.SessionDuration) As Total_Minutes_Work ,Convert(decimal(10,2),sum( SessionDuration )) / 60 as Total_Hours_Work 
                            from UsersTb inner join LoginRecordsTb 
                            on UsersTb.UserID =LoginRecordsTb.UserID   
                            where LoginRecordsTb.LoginDateTime >= @StartDate
                             and LoginRecordsTb.LoginDateTime < @EndDate
                            group by UsersTb.UserName";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@StartDate", SqlDbType.DateTime2).Value = date.Date;
                    command.Parameters.Add("@EndDate", SqlDbType.DateTime2).Value = date.Date.AddDays(1);

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


        public static DataTable GetTotalWorkPeriodForUsersByTwoDates(DateTime Start, DateTime End)
        {
            DataTable dt = new DataTable();
            string query = @"select UsersTb.UserName ,Sum(LoginRecordsTb.SessionDuration) As Total_Minutes_Work ,Convert(decimal(10,2),sum( SessionDuration )) / 60 as Total_Hours_Work 
                            from UsersTb inner join LoginRecordsTb 
                            on UsersTb.UserID =LoginRecordsTb.UserID   
                            where LoginRecordsTb.LoginDateTime >= @StartDate
                             and LoginRecordsTb.LoginDateTime < @EndDate
                            group by UsersTb.UserName";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@StartDate", SqlDbType.DateTime2).Value = Start.Date;
                    command.Parameters.Add("@EndDate", SqlDbType.DateTime2).Value = End.Date.AddDays(1);

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

        public static DataTable GetTotalSalesForUsersByDate(DateTime date)
        {
            DataTable dt = new DataTable();
            string query = @"select    U.UserName ,   Sum(I.NetValue) As Totalsales   from UsersTb U inner join OrdersTb  O  
                            on O.UserID =U.UserID 
                            inner join InvoicesTb I 
                            on I.OrderID=O.OrderID  
                            where I.InvoiceDate >= @Start   and I.InvoiceDate < @End 
                            group By U.UserName ";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Start", SqlDbType.DateTime2).Value = date.Date;
                    command.Parameters.Add("@End", SqlDbType.DateTime2).Value = date.Date.AddDays(1);

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

        public static DataTable GetTotalSalesForUsersByTwoDates(DateTime Start, DateTime End)
        {
            DataTable dt = new DataTable();
            string query = @"select    U.UserName ,   Sum(I.NetValue) As TotalSales   from UsersTb U inner join OrdersTb  O  
                            on O.UserID =U.UserID 
                            inner join InvoicesTb I 
                            on I.OrderID=O.OrderID  
                            where I.InvoiceDate >= @Start   and I.InvoiceDate < @End 
                            group By U.UserName ";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Start", SqlDbType.DateTime2).Value = Start.Date;
                    command.Parameters.Add("@End", SqlDbType.DateTime2).Value = End.Date.AddDays(1);

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

        public static decimal   GetTotalSalesByDate(DateTime Start)
        {
            string query = @"select Sum(NetValue) from InvoicesTb  where InvoiceDate >= @Start and 
                            InvoiceDate < @End " ;  
            try
            {
                using(SqlConnection connection  = new SqlConnection(Settings.Connectionstring)) 
                    using (SqlCommand command = new SqlCommand( query, connection))
                {
                    command.Parameters.Add("@Start" ,SqlDbType.DateTime2).Value=Start.Date;
                    command.Parameters.Add("@End", SqlDbType.DateTime2).Value = Start.Date.AddDays(1);  
                    
                    connection.Open();
                    object result = command.ExecuteScalar();  

                    if(result == null || result ==DBNull.Value)
                    {
                        return 0;    

                    } else

                    {
                        return Convert.ToDecimal(result); 
                    }

                }

            }catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return -1;
            }
        }

        public static decimal   GetTotalSalesByTwoDates(DateTime Start ,DateTime End)
        {
            string query = @"select Sum(NetValue) from InvoicesTb  where InvoiceDate >= @Start and 
                            InvoiceDate < @End ";
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Start", SqlDbType.DateTime2).Value = Start.Date;
                    command.Parameters.Add("@End", SqlDbType.DateTime2).Value = End.Date.AddDays(1);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        return 0;

                    }
                    else

                    {
                        return Convert.ToDecimal(result);
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
