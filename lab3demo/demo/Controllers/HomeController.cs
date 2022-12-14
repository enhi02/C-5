using demo.interfaces;
using demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Controllers
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
            ViewBag.message1 = "First Instance" + _transientService1.GetID().ToString();
            ViewBag.message2 = "Second Instance" + _transientService2.GetID().ToString();
            ViewBag.message3 = "First Instance" + _scopedService1.GetID().ToString();
            ViewBag.message4 = "Second Instance" + _scopedService2.GetID().ToString();
            ViewBag.message5 = "First Instance" + _isingletonService1.GetID().ToString();
            ViewBag.message6 = "Second Instance" + _isingletonService2.GetID().ToString();
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

        ITransientService _transientService1;
        ITransientService _transientService2;
        IScopedService _scopedService1;
        IScopedService _scopedService2;
        ISingletonService _isingletonService1;
        ISingletonService _isingletonService2;

        public HomeController(ITransientService transientService1, 
                              ITransientService transientService2,
                              IScopedService scopedService1,
                              IScopedService scopedService2,
                              ISingletonService isingletonService1,
                              ISingletonService isingletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _isingletonService1 = isingletonService1;
            _isingletonService2 = isingletonService2;
        }


    }
}
