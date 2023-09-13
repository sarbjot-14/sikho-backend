using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sikho_backend.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Industry> Industries {get; set;}
    }
}