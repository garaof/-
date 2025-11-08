using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolobalClasses
{
    public  class GOrderDetailsRecord
    {
          public int OrderDetailID {  get; set; }    
          public int OrderID { get; set; }    
          public int DishID { get; set; } 
          public string DishName { get; set; }    
          public decimal DishPrice { get; set; }     
          public short Units { get; set; }   
          public decimal Total {  get; set; }    

        public GOrderDetailsRecord()
        {
            OrderDetailID = -1;
            OrderID = -1;   
            DishID = -1;     
            DishPrice = -1;
            Units = -1; 
            Total = -1; 
        } 
    }
}
