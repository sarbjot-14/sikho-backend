using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sikho_backend.Models
{
    public class DataPoint
    {
        public int Id {get; set;}
        public int CompanyId {get; set;}
        public Company Company {get;set;} = null!; 
        
     
        public string? units_source {get; set;} 

        public int? units {get;set;}


       
        public string? cost_source {get; set;} 
        public int? cost {get;set;}

        public DateTime? year {get;set;}
    }
}