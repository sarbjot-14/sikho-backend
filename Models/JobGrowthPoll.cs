using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sikho_backend.Models
{
    public class JobGrowthPoll
    {
         [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id {get; set;}
        public int percent_change {get; set;}

        public string ip_address {get; set;}

        public int occupation_id {get; set;}

        
    }
}