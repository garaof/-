using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolobalClasses
{
    public class GDish
    {
        public int DishID { get; set; }  
        public string DishName { get; set; }      
        public decimal DishPrice { get; set; } 
        public string ImagePath { get; set; }    
        public string Description { get; set; }  
        public bool IsAvailable {  get; set; }   
        public int CategoryID {  get; set; }
        public bool IsDeleted { get; set; } 

        public GDish()
        {
            DishID = -1; 
            DishName = string.Empty;     
            DishPrice = -1;
            ImagePath = string.Empty;   
            Description = string.Empty; 
            IsAvailable = false;    
            CategoryID = -1;  
            IsDeleted = false;  
        }
    }
}
