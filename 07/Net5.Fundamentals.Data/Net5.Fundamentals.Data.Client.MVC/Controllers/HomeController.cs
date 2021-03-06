using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Net5.Fundamentals.Data.Client.MVC.Data;
using Net5.Fundamentals.Data.Client.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Net5.Fundamentals.Data.Client.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DataBase dataBase = new DataBase();
            List<Customer> customers = new List<Customer>();
            customers = dataBase.ListCustomers();

            return View(customers);
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
