using Bai2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bai2.Interface;
using Bai2.Services;

namespace Bai2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IGetAllList _GetAll;

        public HomeController(ILogger<HomeController> logger,IGetAllList GetAll)
        {
            _GetAll = GetAll;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _GetAll = new ProductServices();
            return View(_GetAll.GetAll());
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
