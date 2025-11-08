using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolobalClasses
{
    public  class GInvoice
    { 
        public int OrderID { get; set; }     
        public DateTime InvoiceDate { get; set; }   
        public decimal Total {  get; set; } 
        public decimal DeliveryCost { get; set; }    
        public decimal Tax {  get; set; }   
        public decimal Service {  get; set; }   
        public decimal Discount { get; set; }    
        public decimal NetValue { get; set; }    
        public string InvoiceNumber { get; set; }   


        public GInvoice()
        {
            OrderID = -1;
            InvoiceDate = DateTime.Now;
            Total = -1; 
            DeliveryCost = -1;  
            Tax = -1;    
            Service = -1;   
            Discount = -1;  
            NetValue = -1;
            InvoiceNumber = string.Empty; 
        } 
    }
}
