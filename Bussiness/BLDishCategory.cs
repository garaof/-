using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Bussiness
{
    public  class BLDishCategory
    {
        public static GDishCategory GetDishCategoryByID(int categoryid)
        {
           return DADishCategory.GetDishCategoryByID(categoryid);
        }
        public static List<string> GetAllDishCategories() 
        {
            return DADishCategory.GetAllDishCategories();   
        }
        public static int GetCategoryIDCategoryByName(string cagtegoryname)
        {
           return DADishCategory.GetCategoryIDCategoryByName( cagtegoryname); 
        }

    }
}
