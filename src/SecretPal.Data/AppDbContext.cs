using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SecretPal.Data.Models;
using System;

namespace SecretPal.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public DbSet<Gift> Gifts { get; set; }



        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
