using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {

        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ViewResult About()
        {
            return View("About");
        }
    }
}
