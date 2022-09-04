using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using EFCore_NorthwindDb;

namespace EFCore_NorthwindApp
{
    class Program
    {
        private static IConfigurationRoot Configuration;
        private static DbContextOptionsBuilder<NorthwindContext> optionBuilder;

        static void Main(string[] args)
        {
            BuilConfiguration();
            Console.WriteLine($"ConnectionString : {Configuration.GetConnectionString("NorthWindDS")}");
            BuildOptions();

            ListCustomer();
        }

        static void BuilConfiguration()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }


        static void BuildOptions()
        {
            optionBuilder = new DbContextOptionsBuilder<NorthwindContext>();
            optionBuilder.UseSqlServer(Configuration.GetConnectionString("NorthWindDS"));
        }


        static void ListCustomer()
        {
            using (var db = new NorthwindContext(optionBuilder.Options))
            {
                var customers = db.Customers.OrderByDescending(x => x.CompanyName).Take(10).ToList();
                foreach (var cust in customers)
                {
                    Console.WriteLine($"{cust.CompanyName} {cust.ContactName}");
                }
            }
        }
    }
}