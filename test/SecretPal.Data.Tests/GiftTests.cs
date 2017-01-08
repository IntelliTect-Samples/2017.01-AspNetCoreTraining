using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SecretPal.Data.Models;

namespace SecretPal.Data.Tests
{
    [TestClass]
    public class GiftTests: InMemoryTestBase
    {
        [TestMethod]
        public void GiftCount()
        {
            Db.Gifts.Add(new Models.Gift() { Name = "Truck" });
            Db.SaveChanges();
            Assert.AreEqual(1, Db.Gifts.Count());
            Db.Gifts.Remove(Db.Gifts.First());
            Db.SaveChanges();
            Assert.AreEqual(0, Db.Gifts.Count());
        }

        /// <summary>
        /// Make 
        /// </summary>
        [TestMethod]
        public void DbInitializerTest()
        {
            DbInitializer.Initialize(Db);
            Assert.AreEqual(2, Db.Gifts.Count());
            // Make sure it doesn't run twice.
            DbInitializer.Initialize(Db);
            Assert.AreEqual(2, Db.Gifts.Count());
            // Set it back to the beginning.
            Db.Gifts.RemoveRange(Db.Gifts);
            Db.SaveChanges();
            Assert.AreEqual(0, Db.Gifts.Count());
        }


        /// <summary>
        /// Make 
        /// </summary>
        [TestMethod]
        public void CostTotal()
        {
            DbInitializer.Initialize(Db);
            Assert.AreEqual(30, Gift.TotalCost(Db));
        }
    }
}
