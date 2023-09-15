using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

public enum CompanyTypes
{
    Automatic,
    Manual
}  

namespace sikho_backend.Models
{
    public class Company
    {
        public int Id {get; set;}
        public int IndustryId {get; set;}
        public Industry Industry {get; set;} = null!; // Required Reference
        
        [Required]
        public string website_link {get; set;} = string.Empty;
        
        [Required]
        public CompanyTypes type {get; set;} = CompanyTypes.Automatic;
    }
}