using Microsoft.EntityFrameworkCore;
using SecretPal.Data.Models;
using System;

namespace SecretPal.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Gift> Gifts { get; set; }


        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

    }
}
