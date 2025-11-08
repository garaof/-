using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public   class DAAdditionalServices
    { 
        public static bool UpdateAdditionalServices(GAdditionalServices S) 
        {
            string query = @"update AdditionalServicesTb set 
                                                  DeliveryCost= @DeliveryCost ,
												  Service= @Service ,
												  DisCountAsPercent= @DisCountAsPercent ,
												  DisCountAsNumber= @DisCountAsNumber ,
												  Tax= @Tax ,
												  IsTaxIncluded= @IsTaxIncluded ,
                                                  IsDisCountAsPercent = @IsDisCountAsPercent;"; 
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DeliveryCost", S.DeliveryCost);
                    command.Parameters.AddWithValue("@Service", S.Service);
                    command.Parameters.AddWithValue("@DisCountAsPercent", S.DisCountAsPercent);
                    command.Parameters.AddWithValue("@DisCountAsNumber", S.DiscountAsNumber);
                    command.Parameters.AddWithValue("@Tax", S.Tax);
                    command.Parameters.AddWithValue("@IsTaxIncluded", S.IsTaxIncluded);
                    command.Parameters.AddWithValue("@IsDisCountAsPercent", S.IsDisCountAsPercent);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;

                }
            }catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return false;   
            }


        }  

        public static GAdditionalServices GetAdditionalServices()
        {
            string query = @"select * from AdditionalServicesTb";
            try
            {
                using(SqlConnection connection = new SqlConnection(Settings.Connectionstring)) 
                    using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open(); 
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GAdditionalServices()
                            {
                                LineID = Convert.ToInt16(reader["LineID"]),
                                DeliveryCost = Convert.ToDecimal(reader["DeliveryCost"]),
                                Service = Convert.ToDecimal(reader["Service"]),
                                DisCountAsPercent = Convert.ToDecimal(reader["DisCountAsPercent"]),
                                DiscountAsNumber = Convert.ToDecimal(reader["DisCountAsNumber"]),
                                Tax = Convert.ToDecimal(reader["Tax"]),
                                IsTaxIncluded = Convert.ToBoolean(reader["IsTaxIncluded"]),
                                IsDisCountAsPercent = Convert.ToBoolean(reader["IsDisCountAsPercent"])
                            };
                        }

                        return null; 
                    }
                }
            } catch(Exception ex)
            {
                Logger.Log(ex.Message); 
                return null;
            }
        }

    }
}
