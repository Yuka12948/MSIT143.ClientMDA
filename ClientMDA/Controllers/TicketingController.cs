using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.Controllers
{
    public class TicketingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieInfoIndex()
        {
            return View();
        }
        public IActionResult MovieInfoIndex2()
        {
            return View();
        }

        public IActionResult SeatMap()
        {
            return View();
        }

        public IActionResult PaymentWeb()
        {
            return View();
        }

        public IActionResult PaymentWeb2()
        {
            return View();
        }
    }
}
