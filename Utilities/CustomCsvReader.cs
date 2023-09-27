using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using sikho_backend.Models;

namespace sikho_backend.Utilities
{
    public class CustomCsvReader
    {
        public CustomCsvReader(){} 

        public List<Occupation> readOccupationData(){
            Console.WriteLine("whoo hoo ");
            string inputFile = "Data/EmploymentProjections.csv";
            List<Occupation> occupations = new();
            var conf = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                TrimOptions = TrimOptions.Trim,
                MissingFieldFound = null,
                HeaderValidated = null
            };


            using var reader = new StreamReader(inputFile);
            using var csv = new CsvReader(reader, conf);
          
            var records = csv.GetRecords<Occupation>().ToList();
          


            for(var i = 0;i <records.Count; i++){
               
                records[i].Id = i+1;
                records[i].title = records[i].title.Split('*')[0].Trim();
                Console.WriteLine($"the id is {records[i].Id}");
            
            }
            return records;
        }
    }

   
}