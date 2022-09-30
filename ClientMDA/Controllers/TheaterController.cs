using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.Controllers
{
    public class TheaterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult 即將上映()
        {
            return View();
        }
    }
}
