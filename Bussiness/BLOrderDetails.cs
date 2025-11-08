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
    public  class BLOrderDetails
    {
        public static List<GOrderDetailsRecord> GetAllOrderDetailsByOrderID(int OrderID)
        {
            return DAOrderDetails.GetAllOrderDetailsByOrderID(OrderID);
        }

        public static DataTable GetTotalSalesForDishes(DateTime StartDate, DateTime EndDate)
        {
            return DAOrderDetails.GetTotalSalesForDishes(StartDate, EndDate);
        }

        public static GOrderDetailsRecord GetOrderDetailRecord(int ID)
        {
            return DAOrderDetails.GetOrderDetailRecord(ID);
        }

        public static int AddNewOrderDetailRecord(GOrderDetailsRecord ODR)
        {
            return DAOrderDetails.AddNewOrderDetailRecord(ODR);
        }  

    }
}
