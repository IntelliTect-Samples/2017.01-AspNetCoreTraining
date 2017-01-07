using SecretPal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretPal.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext db)
        {
            if (!db.Gifts.Any())
            {
                db.Gifts.Add(new Gift() { Name = "Truck" });
                db.Gifts.Add(new Gift() { Name = "Doll" });
                db.SaveChanges();
            }
        }
    }
}
