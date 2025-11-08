using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolobalClasses 
{
    public class GOrder
    {
        public int OrderID { get; set; }
        //to determine the place to eat {In-out}

        public bool EatIn { get; set; }
        public int TableNumber { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; } 
        public GOrder()
        {
            OrderID = -1;
            EatIn = true;
            TableNumber = -1;   
            UserID = -1;  
            OrderDate = DateTime.Now;   
        }
            

    }
}
