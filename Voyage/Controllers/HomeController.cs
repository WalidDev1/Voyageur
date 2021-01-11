using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Voyage.Models;

namespace Voyage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        string[] ListeVille = {
            "Volvo",
            "BMW",
            "Ford",
            "Mazda"
        };
        string[] ListeOptionBus = {
            "Wifi",
            "Clime",
            "Wc",
            "Tv"
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            @ViewBag.SlectedView = "Home" ;
            @ViewBag.ListeVille = ListeVille ;
            @ViewBag.ListeOptionBus = ListeOptionBus;
            Console.WriteLine(@ViewBag.SlectedView);
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
    }
}
