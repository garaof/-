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
    public class BLDish 
    {
        public static DataTable GetAllDishesInMenue()
        {
            return DADish.GetAllDishesInMenue();

        }

        public static DataTable GetAllDishesByCategoryID(int id)
        {
            return DADish.GetAllDishesByCategoryID(id);

        }

        public static GDish GetDishByID(int dishid)
        {
            return DADish.GetDishByID(dishid);
        }
        public static int AddNewDish(GDish newdish)
        {
           return DADish.AddNewDish(newdish);
        }

        public static bool UpdateDish(GDish dish)
        {
           return DADish.UpdateDish(dish);
        }



        public static bool IsDishExists(int dishid)
        {
            return DADish.IsDishExists(dishid); 
        }

        public static bool DeleteDish(int ID)
        {
            return DADish.DeleteDish(ID);   
        }
    }
}
