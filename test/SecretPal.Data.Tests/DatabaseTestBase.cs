using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecretPal.Data.Tests
{
    public class DatabaseTestBase
    {
        protected AppDbContext Db { get; private set; }

        public DatabaseTestBase()
        {
            var dbOptionBuilder = new DbContextOptionsBuilder();
            dbOptionBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=SecretSantaTest;Trusted_Connection=True;"
            );

            Db = new AppDbContext(dbOptionBuilder.Options);

            // Wipe the database out first;
            Db.Database.EnsureDeleted();

            // Create the database
            Db.Database.Migrate();
        }

    }
}
