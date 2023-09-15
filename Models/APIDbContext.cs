using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;

namespace sikho_backend.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
             List<Industry> currentIndustries = new List<Industry>();
             Industry rideHailing = new Industry(1, IndustryType.RideHailing,"Trips Completed", "Average Cost per Ride", "Estimated Total Sales");
             Industry beverageService = new Industry(2, IndustryType.BeverageService,"Number of Locations", "Sales per Location", "Estimated Total Sales");
             currentIndustries.Add(rideHailing);
             currentIndustries.Add(beverageService);
            modelBuilder.Entity<Industry>().HasData(currentIndustries);

            List<Company> currentCompanies = new List<Company>();
            currentCompanies.Add(new Company(1, 1,"Waymo", "https://waymo.com/",CompanyTypes.Automatic  ));
            currentCompanies.Add(new Company(2, 1,"Cruise", "https://getcruise.com/",CompanyTypes.Automatic  ));
            modelBuilder.Entity<Company>().HasData(currentCompanies);

            base.OnModelCreating(modelBuilder);
        } 

        public DbSet<Industry> Industries {get; set;}
        public DbSet<Company> Companies {get; set;}

        public DbSet<DataPoint> DataPoints {get; set;}
    }
}