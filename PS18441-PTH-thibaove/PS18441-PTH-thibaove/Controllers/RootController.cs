using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PS18441_PTH_thibaove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TestBaoVeMVC.Services;

namespace TestBaoVeMVC.Controllers
{
    public class RootController : Controller
    {
        private IRoot _rootSvc;

        public RootController(IRoot rootSvc)
        {
            _rootSvc = rootSvc;
        }

        // GET: RootController
        public async Task<IActionResult> Index()
        {
            var url = "https://api-demo.vietstock.vn/demonews/latestnews?top=10&languageid=1";
            List<Root> list = new List<Root>();
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                
                using (var response = await client.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<Root>>(apiResponse);
                }
                _rootSvc.AddRoot(list);
            }
            return RedirectToAction("Display");
        }

        public IActionResult Display()
        {
            return View(_rootSvc.GetAll());
        }
        // GET: RootController/Details/5
        public IActionResult Details(int id)
        {
            return View(_rootSvc.GetRootId(id));
        }



        [HttpGet]
        public ActionResult Delete()
        {
            try
            {
                _rootSvc.DeleteRoot();
                return RedirectToAction("Display");
            }
            catch
            {
                return RedirectToAction("Display");
            }
        }
    }
}
