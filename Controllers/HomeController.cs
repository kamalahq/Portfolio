using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ryan.Web.UI.Models;
using Ryan.Web.UI.Models.DataContexts;
using Ryan.Web.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Ryan.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        readonly RyanDbContext db;
        public HomeController(RyanDbContext db)
        {
            this.db = db;
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutMe()
        {
            return View();
        }
       
        public IActionResult Contact() 
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactMe contactme)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contactme);
                db.SaveChanges();

                ModelState.Clear();

                ViewBag.Message = "Sizin sorgunuz qebul edilmisdir.Tezlikle geri donus edeceyik.";
                return View();

            }

            return View(contactme);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
