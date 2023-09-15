using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sikho_backend.Models
{
    public class Industry
    {

        public int Id {get; set;}
        public ICollection<Company> Companies {get; set;} = new List<Company>();
        
        [Required]
        public string unit_title  {get; set;} = string.Empty;

         [Required]
        public string cost_title {get; set;} = string.Empty;

        [Required]
        public string revenue_title {get; set;} = string.Empty;




    
        
    }
}