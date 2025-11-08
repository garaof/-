using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolobalClasses
{
    public  class GAdditionalServices
    { 
        public short LineID { get; set; }  
        public decimal DeliveryCost { get; set; }    
        public decimal Service {  get; set; }    
        public decimal DisCountAsPercent { get; set; }   
        public decimal DiscountAsNumber { get; set; }  
        public decimal Tax {  get; set; }    
        public bool IsTaxIncluded {  get; set; }    
        public bool IsDisCountAsPercent { get; set; } 
        public GAdditionalServices()
        {
            LineID = 1; 
            DeliveryCost = -1;  
            Service = -1;   
            DiscountAsNumber = -1;
            Tax = -1;   
            IsTaxIncluded = true;
            DisCountAsPercent = -1;
            IsDisCountAsPercent = true; 
        } 
    }
}
