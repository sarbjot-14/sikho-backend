using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;

namespace sikho_backend.Models
{
    public class APIDbContext : DbContext
    {
        private readonly ILogger<APIDbContext> _logger;
        public APIDbContext(DbContextOptions options, ILogger<APIDbContext> logger) : base(options) => this._logger = logger;


        protected override void OnModelCreating(ModelBuilder modelBuilder){
            using (StreamReader r = new StreamReader("Data/industryData.json")){
                string mockJson = r.ReadToEnd();
                var industryData = JsonSerializer.Deserialize<List<Industry>>(mockJson);
            
                modelBuilder.Entity<Industry>().HasData(industryData);
                
            }

                using (StreamReader r = new StreamReader("Data/companyData.json")){
                string mockJson = r.ReadToEnd();
                var companyData = JsonSerializer.Deserialize<List<Company>>(mockJson);
      
                modelBuilder.Entity<Company>().HasData(companyData);
                
            }

            base.OnModelCreating(modelBuilder);
        } 

        public DbSet<Industry> Industries {get; set;}
        public DbSet<Company> Companies {get; set;}

        public DbSet<DataPoint> DataPoints {get; set;}
    }
}