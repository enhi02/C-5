using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TestBaoVeMVC.Models;

namespace TestBaoVeMVC.Controllers
{
    public class RootController : Controller
    {
        // GET: RootController
        public async Task<IActionResult> Index()
        {
            var url = "https://localhost:44389/api/";
            List<Root> list = new List<Root>();
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.BaseAddress = new Uri(url);
                using (var response = await client.GetAsync("Root"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<Root>>(apiResponse);
                }
            }
            return View(list);
        }

        // GET: RootController/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var url = "https://localhost:44389/api/";
            Root reservation = new Root();
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization =new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.BaseAddress = new Uri(url);
                using (var response = await client.GetAsync("Root/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Root>(apiResponse);
                }
            }
            return View(reservation);
        }

        // GET: RootController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RootController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Root root)
        {
            try
            {
                string url = "https://localhost:44389/api/Root";
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Authorization =new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                    StringContent content = new StringContent(JsonConvert.SerializeObject(root), System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        //xu ly loi
                        //return Content(response.ToString());
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var ret = JsonConvert.DeserializeObject<Root>(apiResponse);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RootController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RootController/Edit/5
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

        // GET: RootController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: RootController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Root root)
        {
            try
            {
                string url = "https://localhost:44389/api/Root";
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Authorization =new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                    //StringContent content = new StringContent(JsonConvert.SerializeObject(root), System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.DeleteAsync(url);
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        //xu ly loi
                        //return Content(response.ToString());
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var ret = JsonConvert.DeserializeObject<Root>(apiResponse);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
