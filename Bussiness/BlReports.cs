using DataAccess;
using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public  class BlReports
    {
        public static DataTable GetTotalWorkPeriodForUsersByDate(DateTime date)
        {
            return DAReports.GetTotalWorkPeriodForUsersByDate(date);


        }


        public static DataTable GetTotalWorkPeriodForUsersByTwoDates(DateTime Start, DateTime End)
        {

            return   DAReports.GetTotalWorkPeriodForUsersByTwoDates(Start,End);
        }
        public static DataTable GetTotalSalesForUsersByDate(DateTime date)
        {
            return DAReports.GetTotalSalesForUsersByDate(date);


        }

        public static DataTable GetTotalSalesForUsersByTwoDates(DateTime Start, DateTime End)
        {
            return DAReports.GetTotalSalesForUsersByTwoDates(Start, End);
        }

        public static decimal GetTotalSalesByDate(DateTime Start)
        {
            return DAReports.GetTotalSalesByDate(Start);
        }

        public static decimal GetTotalSalesByTwoDates(DateTime Start, DateTime End)
        {
            return DAReports.GetTotalSalesByTwoDates(Start, End); 
        }







    }
}
