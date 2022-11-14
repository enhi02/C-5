using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonAn.Constant;
using WebMonAn.Models;
using WebMonAn.Models.ViewModels;
using WebMonAn.Services;

namespace WebMonAn.Controllers
{
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _IWebHostEnvironment;
        private IUserModelSvc _userModelSvc;

        public AdminController(IWebHostEnvironment webHostEnvironment, IUserModelSvc userModelSvc)
        {
            _IWebHostEnvironment = webHostEnvironment;
            _userModelSvc = userModelSvc;
        }

        public IActionResult Login(string returnUrl)
        {
            string userName = HttpContext.Session.GetString(SessionKey.User.UserName);
            if (userName !=null && userName != "") //đã có ss
            {
                return RedirectToAction("Home", "Index");
            }

            #region Hiển thị Login
            ViewLogin login = new ViewLogin();
            login.ReturnUrl = returnUrl;
            return View(login);
            #endregion
        }

        [HttpPost]
        [ValidateAntiForgeryToken]// quay lại staup

        public IActionResult Login(ViewLogin viewLogin)
        {
            if (ModelState.IsValid)
            {
                UserModel userModel = _userModelSvc.Login(viewLogin);
                if (userModel != null)
                {
                    HttpContext.Session.SetString(SessionKey.User.UserName, userModel.UserName);
                    HttpContext.Session.SetString(SessionKey.User.FullName, userModel.FullName);
                    HttpContext.Session.SetInt32("Role", userModel.Role);
                    HttpContext.Session.SetString(SessionKey.User.UserContext, JsonConvert.SerializeObject(userModel));

                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }    
            }   //k// admin t chuwa lamf xong có lỗi luôn kìa// ddm chuwa fix dc edit day
            return View(viewLogin);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
