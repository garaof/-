using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolobalClasses
{
    public  class GDishCategory
    { 
        public int ID { get; set; }  
        public string Name { get; set; } 

        public GDishCategory()
        {
            ID = -1;
            Name = string.Empty;
        } 
    }
}
