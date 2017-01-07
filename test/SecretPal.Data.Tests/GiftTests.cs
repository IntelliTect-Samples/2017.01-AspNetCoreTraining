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
            Db.Gifts.Add(new Models.Gift() { Name = "Truck" });
            Db.SaveChanges();
            Assert.AreEqual(1, Db.Gifts.Count());
        }
    }
}
