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

        [Key]
        public int IndustryId {get; set;}

        [Column(TypeName ="nvarchar(250)")]
        public string Name {get; set;}

    
        
    }
}