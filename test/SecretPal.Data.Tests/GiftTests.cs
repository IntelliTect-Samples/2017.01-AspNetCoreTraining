using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SecretPal.Data.Tests
{
    [TestClass]
    public class GiftTests: DatabaseTestBase
    {
        [TestMethod]
        public void GiftCount()
        {
            db.Gifts.Add(new Models.Gift() { Name = "Truck" });
            db.SaveChanges();
            Assert.AreEqual(1, db.Gifts.Count());
        }
    }
}
