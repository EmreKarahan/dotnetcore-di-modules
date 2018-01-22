using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Example.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Example.Web.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Example.Web.Controllers
{
    public class HomeController : Controller
    {
        private IDataRepository _dataRepository;

        public HomeController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}