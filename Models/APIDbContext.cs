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

           
           
            List<Occupation> occupations = new();
            var conf = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                TrimOptions = TrimOptions.Trim,
                MissingFieldFound = null,
                HeaderValidated = null
            };


            using var reader = new StreamReader("Data/EmploymentProjections.csv");
            using var csv = new CsvReader(reader, conf);
          
            var records = csv.GetRecords<Occupation>().ToList();
          


            for(var i = 0;i <records.Count; i++){
               
                records[i].Id = i+1;
                records[i].title = records[i].title.Split('*')[0].Trim();
               // Console.WriteLine($"the id is {records[i].Id}");
            
            }
            modelBuilder.Entity<Occupation>().HasData(records);

            base.OnModelCreating(modelBuilder);
        } 

        public DbSet<Industry> Industries {get; set;}
        public DbSet<Company> Companies {get; set;}

        public DbSet<DataPoint> DataPoints {get; set;}
        public DbSet<Occupation> Occupations {get; set;}
        public DbSet<JobGrowthPoll> JobGrowthPolls {get; set;}

    }
}