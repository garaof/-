using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GolobalClasses
{
    public class GPerson {
        public int PersonID {  get; set; }     
        public string FirstName { get; set; } 
        public string LastName { get; set; }     
        public string Phone {  get; set; }   
        public string Email { get; set; }    
        public string Address { get; set; }  
        public string JobTitle { get; set; } 
        
        public GPerson()
        {
            this.PersonID = -1; 
            this.FirstName= string.Empty;   
            this.LastName= string.Empty; 
            this.Phone = string.Empty;   
            this.Email = string.Empty; 
            this.Address = string.Empty; 
            this.JobTitle = string.Empty;
        }
    }  


    
}
