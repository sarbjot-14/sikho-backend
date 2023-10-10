using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;
using sikho_backend.Utilities;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text.Json.Serialization;

namespace sikho_backend.Models
{
    public class APIDbContext : DbContext
    {
        private readonly ILogger<APIDbContext> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public APIDbContext(DbContextOptions options, ILogger<APIDbContext> logger, IWebHostEnvironment hostingEnvironment) : base(options){this._logger = logger; this._hostingEnvironment = hostingEnvironment;} 


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

            using (StreamReader r = new StreamReader("Data/datapointsData.json")){
                string mockJson = r.ReadToEnd();
                var datapointData = JsonSerializer.Deserialize<List<DataPoint>>(mockJson);
      
                modelBuilder.Entity<DataPoint>().HasData(datapointData);
                
            }

           
           
            using (StreamReader r = new StreamReader("Data/EmploymentProjections.json")){
                string mockJson = r.ReadToEnd();
                var options = new JsonSerializerOptions()
                    {
                        NumberHandling = JsonNumberHandling.AllowReadingFromString |
                        JsonNumberHandling.WriteAsString
                    };

                var occupationsData = JsonSerializer.Deserialize<List<Occupation>>(mockJson, options);
                  for(var i = 0;i <occupationsData.Count; i++){
                        occupationsData[i].Id = i+1;
                        occupationsData[i].title = occupationsData[i].title.Split('*')[0].Trim();
            
                  }
                modelBuilder.Entity<Occupation>().HasData(occupationsData);
                
            }

          


            base.OnModelCreating(modelBuilder);
        } 

        public DbSet<Industry> Industries {get; set;}
        public DbSet<Company> Companies {get; set;}

        public DbSet<DataPoint> DataPoints {get; set;}
        public DbSet<Occupation> Occupations {get; set;}
        public DbSet<JobGrowthPoll> JobGrowthPolls {get; set;}

    }
}