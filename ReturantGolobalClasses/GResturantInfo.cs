using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolobalClasses
{
     public  class GResturantInfo
    {
        public string ResturantName {  get; set; }  
        public string ResturantAddress {  get; set; }   
        public string LogoPath { get; set; } 
        public string Slogan {  get; set; }   


        public GResturantInfo() 
        { 
            ResturantName = string.Empty;   
            ResturantAddress = string.Empty;    
            LogoPath = string.Empty;    
            Slogan = string.Empty;   

        } 
    }
}
