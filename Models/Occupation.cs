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

        [Name("Occupation Title")]
        public string title {get;set;}

        [Name("Employment 2022")]
        [Column(TypeName = "decimal(12, 3)")]
        public decimal currently_employed {get;set;}
         [Column(TypeName = "decimal(12, 3)")]
        [Name("Employment Change, 2022-2032")]
        public float decade_change_percentage {get;set;}

        [Name("Median Annual Wage 2022")]
         [Column(TypeName = "decimal(12, 3)")]
        public decimal median_annual_wage {get; set;}

        [Name("Typical Entry-Level Education")]
        public string education_requirement {get;set;}

         [Name("Industry")]
        public string industry {get;set;}

        [Name("At Risk")]
        public int at_risk {get;set;}

        
    }
}