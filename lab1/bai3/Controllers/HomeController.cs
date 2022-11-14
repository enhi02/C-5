using bai3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bai3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private CompanyContext db = new CompanyContext();
      
        public IActionResult Index()
        {   using(var context = new CompanyContext())
            {
                return View(context.Product.ToList());
            }
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            using (var context = new CompanyContext())
            {
                context.Product.Add(product);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var context = new CompanyContext())
            {
                return View(context.Product.Find(id));
            }
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            using (var context = new CompanyContext())
            {
                context.Product.Find(product.Id).Name = product.Name;
                context.Product.Find(product.Id).Price = product.Price;
                context.Product.Find(product.Id).Quantiny = product.Quantiny;
                context.Product.Find(product.Id).Status = product.Status;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }  
       
        public IActionResult Delete(int id)
        {
            using(var context = new CompanyContext())
            {
                context.Product.Remove(context.Product.Find(id));
                context.SaveChanges();
            }    
            return RedirectToAction("Index");
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
