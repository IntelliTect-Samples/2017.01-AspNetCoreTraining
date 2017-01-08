using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecretPal.Data.Tests
{
    public class InMemoryTestBase
    {
        protected AppDbContext Db { get; private set; }

        public InMemoryTestBase()
        {
            var dbOptionBuilder = new DbContextOptionsBuilder();
            dbOptionBuilder.UseInMemoryDatabase();

            Db = new AppDbContext(dbOptionBuilder.Options);
         }

    }
}
