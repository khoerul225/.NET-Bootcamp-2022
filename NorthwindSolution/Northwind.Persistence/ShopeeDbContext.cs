using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using N

namespace Northwind.Persistence
{
    public class ShopeeDbContext : DbContext
    {
        private static IConfigurationRoot _configuration;
        private static DbContextOptions options;

        public ShopeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
