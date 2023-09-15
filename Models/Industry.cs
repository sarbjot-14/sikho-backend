using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sikho_backend.Models
{

    public enum IndustryType
{
    RideHailing, 
    BeverageService
}  
    public class Industry
    {
        public Industry(int Id, IndustryType type , string unit_title, string cost_title, string revenue_title)
        {
            this.Id = Id;
            this.type = type;
            this.unit_title = unit_title;
            this.cost_title = cost_title;
            this.revenue_title = revenue_title;
        }

        public int Id {get; set;}
        public ICollection<Company> Companies {get; set;} = new List<Company>();
        
        [Required]
        public IndustryType type {get; set;}
        [Required]
        public string unit_title  {get; set;} = string.Empty;

         [Required]
        public string cost_title {get; set;} = string.Empty;

        [Required]
        public string revenue_title {get; set;} = string.Empty;




    
        
    }
}