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
    public  class DAInvoice
    { 
        public static int AddNewInvoice( GInvoice invoice)
        {
            string query = @"insert into InvoicesTb (OrderID,InvoiceDate,ToTal,DeliveryCost,Tax,Service,DisCount,NetValue,InvoiceNumber)
                           Values ( @OrderID , @InvoiceDate , @Total , @DeliveryCost , @Tax , @Service , @DisCount , @NetValue , @InvoiceNumber ) ;
                           select SCOPE_IDENTITY(); " ;  
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                    using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@OrderID", SqlDbType.Int).Value = invoice.OrderID;
                    command.Parameters.Add("@InvoiceDate", SqlDbType.DateTime2).Value = invoice.InvoiceDate;
                    command.Parameters.Add("@Total", SqlDbType.Decimal).Value = invoice.Total;
                    command.Parameters.Add("@DeliveryCost", SqlDbType.Decimal).Value = invoice.DeliveryCost;
                    command.Parameters.Add("@Tax", SqlDbType.Decimal).Value = invoice.Tax;
                    command.Parameters.Add("@Service", SqlDbType.Decimal).Value = invoice.Service;
                    command.Parameters.Add("@DisCount", SqlDbType.Decimal).Value = invoice.Discount;
                    command.Parameters.Add("@NetValue", SqlDbType.Decimal).Value = invoice.NetValue;
                    command.Parameters.Add("@InvoiceNumber", SqlDbType.NVarChar).Value = invoice.InvoiceNumber;

                    connection.Open();

                    object result = command.ExecuteScalar(); 

                    if(result != null  && int.TryParse(result.ToString() ,out int insertedid))
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

        public static int GetNewInvoiceID()
        {
            string query = @"select IsNull(Max(InvoiceID),0) +1 from InvoicesTb";
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                    using(SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return (int)command.ExecuteScalar(); 
                }
            } catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return -1;  
            } 
        }

        public static GInvoice FindInvoiceByID(int invoiceid)
        {
            string query = @"select * from InvoicesTb where InvoiceID = @ID "; 
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = invoiceid;

                    connection.Open(); 
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GInvoice()
                            {
                                OrderID = Convert.ToInt32(reader["OrderID"]),
                                InvoiceDate = Convert.ToDateTime(reader["InvoiceDate"]),
                                Total = Convert.ToDecimal(reader["ToTal"]),
                                DeliveryCost = Convert.ToDecimal(reader["DeliveryCost"]),
                                Tax = Convert.ToDecimal(reader["Tax"]),
                                Service = Convert.ToDecimal(reader["Service"]),
                                Discount = Convert.ToDecimal(reader["DisCount"]),
                                NetValue = Convert.ToDecimal(reader["NetValue"]),
                                InvoiceNumber = Convert.ToString(reader["InvoiceNumber"])
                            };
                        }
                        else
                        {
                            return null; 
                        }
                    }

                }
            } catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return null;    
            }  
        }

        public static DataTable GetLast100Invoice()
        {
            string query = @"select top 100 InvoiceID,InvoiceDate,ToTal,NetValue,InvoiceNumber  from InvoicesTb  order by InvoiceDate desc"; 
            DataTable dt = new DataTable(); 
            try
            {
              using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open(); 
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    } 
                    return dt;  
                }
            }catch(Exception ex)
            {
                Logger.Log(ex.Message);
                return null; 
            }
        }    


        public static DataTable FindAllInvoicesInSpecificDate(DateTime date)
        {
            string query = @"select * from InvoicesTb where
                            InvoiceDate >= @StartDate and InvoiceDate < @EndDate"; 
            DataTable dt = new DataTable(); 

            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", date.Date);
                    cmd.Parameters.AddWithValue("@EndDate", date.Date.AddDays(1));
                    connection.Open(); 

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                        return dt; 
                    }
                }
            }catch(Exception ex)
            {
                Logger.Log(ex.Message);
                return null; 
            }
        }


    }
}
