using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using core_bili.Models;
using core_bili.Myserver;

namespace core_bili.Controllers
{

    public class HomeController : Controller
    {
        private readonly IMyserver<student> myserver;

        public HomeController(IMyserver<student> myserver)
        {
            this.myserver = myserver;
        }

        public IActionResult Index()
        {
 
            var list = myserver.GetAll();
            return View(list);
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

        [HttpPost]

        public IActionResult ff(int a, string b, DateTime c) {

            return Content("ss");
        }
    }
}
