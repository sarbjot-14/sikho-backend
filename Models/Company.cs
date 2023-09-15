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
       

        public Company(int Id, int industryId,  string name,  string website_link, CompanyTypes type) 
        {
            this.Id = Id;
            
            this.IndustryId = industryId;
            this.name =name;
            this.website_link = website_link;
            this.type = type;
   
        }
 
       public int Id {get; set;}
        public int IndustryId {get; set;}
        public Industry Industry {get; set;} = null!; // Required Reference
        
         [Required]
        public string name {get; set;} = string.Empty;
        [Required]
        public string website_link {get; set;} = string.Empty;
        
        [Required]
        public CompanyTypes type {get; set;} = CompanyTypes.Automatic;
        public ICollection<DataPoint> DataPoints {get; set;} = new List<DataPoint>();

    }
}