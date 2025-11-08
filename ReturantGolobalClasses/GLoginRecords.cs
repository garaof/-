using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturantGolobalClasses
{
    public  class GLoginRecords
    { 
        public DateTime LoginDateTime { get; set; }     
        public DateTime ? LogoutDateTime { get; set; }   
        public int ? SessionDuration { get; set; }    
        public int UserID { get; set; } 

        public GLoginRecords()
        {
            UserID = -1;
            LoginDateTime = DateTime.Now; 
            LogoutDateTime = null;
            SessionDuration = null;
        } 
    }
}
