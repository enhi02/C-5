﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMonAn.Constant;

namespace WebMonAn.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {

        }

        protected string GetUserName()
        {
            return HttpContext.Session.GetString(SessionKey.User.UserName);
        }

        protected string GetFullName()
        {
            return HttpContext.Session.GetString(SessionKey.User.FullName);
        }

        protected string GetKHẺmail()
        {
            return HttpContext.Session.GetString(SessionKey.KhachHang.KH_Email);
        }

        // GET: BaseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BaseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BaseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BaseController/Create
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

        // GET: BaseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BaseController/Edit/5
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

        // GET: BaseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BaseController/Delete/5
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