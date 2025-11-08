using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolobalClasses
{
    public  class GUser
    {
        public int UserID { get; set; }  
       
        public string UserName {  get; set; } 
        public string Password { get; set; } 
        public GPerson Person { get; set; } 
        public GRoles Role {  get; set; }    
        public bool IsActive { get; set; }  

        public GUser()
        {
            UserID = -1; 
                
            UserName = string.Empty;     
            Password = string.Empty;     
            Person = new GPerson();  
            Role = new GRoles();     
            IsActive = false;    
        } 
    }
}
