using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace sikho_backend.Models
{
    public class Occupation
    {
        

        public int Id {get; set;}


        public string title {get;set;}


        public string currently_employed {get;set;}

        public float decade_change_percentage {get;set;}


        public string median_annual_wage {get; set;}

 
        public string education_requirement {get;set;}

    
        public string industry {get;set;}

  
        public int at_risk {get;set;}

        
    }
}