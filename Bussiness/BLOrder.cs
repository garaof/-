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
    public  class BLOrder
    {
        public static GOrder GetOrderByID(int id)
        {
            return DAOrder.GetOrderByID(id);
        }

        public static int AddNewOrder(GOrder newOrder)
        {
            return DAOrder.AddNewOrder(newOrder);
        }
    }
}
