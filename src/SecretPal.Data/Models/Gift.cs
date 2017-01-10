using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretPal.Data.Models
{
     public class Gift
    {
        public int GiftId { get; set; }
        public string Name { get; set; }

        public decimal Cost { get; set; }



        public static decimal TotalCost(AppDbContext db)
        {
            return db.Gifts.Sum(f => f.Cost);
        }
    }
}
