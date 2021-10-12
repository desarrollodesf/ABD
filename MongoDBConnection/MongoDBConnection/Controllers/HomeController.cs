using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using MongoDBConnection.Models;

namespace MongoDBConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
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

        public ActionResult Query1()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Query1(Query query)
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("Taller1"));
            var dbList = dbClient.GetDatabase("prueba").GetCollection<prueba1>("prueba1").AsQueryable();

            query.resultado = Newtonsoft.Json.JsonConvert.SerializeObject(new JsonResult(dbList));

            try
            {
                return View("Resultado", query);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Query2()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Query2(Query query)
        {
            try
            {
                return View("Resultado", query);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Query3()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Query3(Query query)
        {
            try
            {
                return View("Resultado", query);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Query4()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Query4(Query query)
        {
            try
            {
                return View("Resultado", query);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Query5()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Query5(Query query)
        {
            try
            {
                return View("Resultado", query);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Query6()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Query6(Query query)
        {
            try
            {
                return View("Resultado", query);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Query7()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Query7(Query query)
        {
            try
            {
                return View("Resultado", query);
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Resultado()
        {
            return View();
        }
    }
}
