using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SonalCRUD_ADO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SonalCRUD_ADO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        StudentDataAccess dataAccess;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            dataAccess = new StudentDataAccess();
        }

        public IActionResult Index()
        {
            var std = dataAccess.GetStudents();
            return View(std);
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
