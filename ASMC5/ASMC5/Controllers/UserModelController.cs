using WebMonAn.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonAn.Models;

namespace WebMonAn.Controllers
{
    public class UserModelController : Controller
    {
        private readonly IWebHostEnvironment _IWebHostEnvironment;
        private IUserModelSvc _userModelSvc;

        public UserModelController(IWebHostEnvironment webHostEnvironment, IUserModelSvc userModelSvc)
        {
            _IWebHostEnvironment = webHostEnvironment;
            _userModelSvc = userModelSvc;
        }
        // GET: UserModelController
        public ActionResult Index()
        {
            return View(_userModelSvc.GetUserModelAll());
        }

        // GET: UserModelController/Details/5
        public ActionResult Details(int id)
        {
            var userModel = _userModelSvc.GetUserModel(id);
            return View(userModel);
        }

        // GET: UserModelController/Create
        public ActionResult Create()
        {
            ViewData["Role"] = _userModelSvc.GetSelectList();
            return View();
        }

        // POST: UserModelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserModel userModel)
        {
            try
            {
                _userModelSvc.AddUserModel(userModel);
                return RedirectToAction("Login", "Admin");

            }
            catch
            {
                ViewData["Role"] = _userModelSvc.GetSelectList(userModel);
                return View();
            }
        }

        public ActionResult Register()
        {
            ViewData["Role"] = _userModelSvc.GetSelectList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserModel userModel)
        {
            try
            {
                _userModelSvc.AddUserModel(userModel);
                return RedirectToAction("Login", "Admin");

            }
            catch
            {
                ViewData["Role"] = _userModelSvc.GetSelectList(userModel);
                return View();
            }
        }

        // GET: UserModelController/Edit/5
        public ActionResult Update(int id)
        {
            var userModel = _userModelSvc.GetUserModel(id);
            ViewData["Role"] = _userModelSvc.GetSelectList();
            return View(userModel);
        }

        // POST: UserModelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                _userModelSvc.EditUserModel(id, userModel);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Role"] = _userModelSvc.GetSelectList(userModel);
            return View(userModel);
        }

        // GET: UserModelController/Delete/5
        public IActionResult Delete(int id)
        {
            var userModel = _userModelSvc.GetUserModel(id);
            if (userModel == null)
            {
                return NotFound();
            }
            return View(userModel);
        }

        // POST: UserModelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction(nameof(Index)); // chỗ này á haha
            }
            catch
            {
                return View();
            }
        }

        //public IActionResult Login()
        //{
        //    var food = _userModelSvc.GetUserModelAll();
        //    return View(food);
        //}


        //public IActionResult Register()
        //{
        //    var food = _foodModelSvc.GetFoodModelAll();
        //    return View(food);
        //}

        //public IActionResult ForgotPassword()
        //{
        //    var food = _foodModelSvc.GetFoodModelAll();
        //    return View(food);
        //}
    }
}
