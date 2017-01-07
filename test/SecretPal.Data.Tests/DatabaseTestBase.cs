using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecretPal.Data.Tests
{
    public class DatabaseTestBase
    {
        protected AppDbContext db { get; private set; }

        public DatabaseTestBase()
        {
            var dbOptionBuilder = new DbContextOptionsBuilder();
            dbOptionBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=SecretSantaTest;Trusted_Connection=True;"
            );

            db = new AppDbContext(dbOptionBuilder.Options);

            // Wipe the database out first;
            db.Database.EnsureDeleted();

            // Create the database
            db.Database.Migrate();
        }

    }
}
