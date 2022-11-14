using WebMonAn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebMonAn.Services;
using Microsoft.AspNetCore.Http;
using WebMonAn.Constant;

namespace WebMonAn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IFoodModelSvc _foodModelSvc;

        private IUserModelSvc _userModelSvc;


        public HomeController(ILogger<HomeController> logger, IFoodModelSvc foodModel, IUserModelSvc userModelSvc)
        {
            _foodModelSvc = foodModel;
            _logger = logger;
            _userModelSvc = userModelSvc;
        }

        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString(SessionKey.User.UserName);
            ViewBag.Role = HttpContext.Session.GetInt32("Role");
            var food = _foodModelSvc.GetFoodModelAll();
            return View(food);
        }

        public IActionResult Details( int id)
        {
            var food = _foodModelSvc.GetFoodModel(id);
            return View(food);
        }

        public IActionResult Shop()
        {
            var food = _foodModelSvc.GetFoodModelAll();
            return View(food);
        }

        public IActionResult Contact()
        {
            var food = _foodModelSvc.GetFoodModelAll();
            return View(food);
        }

        public IActionResult CheckOut()
        {
            var food = _foodModelSvc.GetFoodModelAll();
            return View(food);
        }

        public IActionResult Cart()
        {
            var food = _foodModelSvc.GetFoodModelAll();
            return View(food);
        }

        //public IActionResult Login()
        //{
        //    var food = _foodModelSvc.GetFoodModelAll();
        //    return View(food);
        //}

        //public IActionResult Register()
        //{
        //    var food = _foodModelSvc.GetFoodModelAll();
        //    return View(food);
        //}

        public IActionResult ForgotPassword()
        {
            var food = _foodModelSvc.GetFoodModelAll();
            return View(food);
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
