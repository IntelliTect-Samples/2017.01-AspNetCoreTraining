using Microsoft.AspNetCore.Mvc;
using SecretPal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPal.Web.Controllers
{
    public class HomeController: Controller
    {
        public AppDbContext Db { get; }

        public HomeController(AppDbContext db)
        {
            Db = db;
        }


        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            ViewBag.GiftCount = Db.Gifts.Count();
            return View();
        }
    }
}
