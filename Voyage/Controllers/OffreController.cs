using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Voyage.Views.Offre
{
    public class OffreController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            @ViewBag.SlectedView = "Offre";
            Console.WriteLine(@ViewBag.SlectedView);
            return View();
        }
    }
}
