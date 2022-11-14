using Lab6.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Lab6.Controllers
{
    public class ReservationClientController : Controller
    {
        public ReservationClientController()
        {

        }
        // GET: ReservationClientController
        public async Task<ActionResult> Index()
        {
            //var url = "https://" + Request.Host + "/api/";
            string accessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJTZWN1cmVBcGlXaXRoQWNlc3NUb2tlbiIsImp0aSI6IjY0NWI0NmEwLTRiZjYtNDNiYy1iNmE5LWUxYjA3OGNjNWY0NSIsImlhdCI6IjYvMTEvMjAyMSAxMjo0Nzo1NiBQTSIsIklkIjoiMSIsIkZ1bGxOYW1lIjoiUGh1b25nIER1bmciLCJFbWFpbCI6ImNoaW5oY2h1QGdtYWlsLmNvbSIsImV4cCI6MTYyMzUwMjA3NiwiaXNzIjoiU2VjdXJlU2VydmVyQXBpIiwiYXVkIjoiU2VjdXJlQXBpQ2xpZW50In0.60wbH0Pspt3R-Iy7hSl-XpFE_03w8vOiHSNZ3fNS9DQ";
            var url = "https://localhost:44314/api/";
            List<Reservation> list = new List<Reservation>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.BaseAddress = new Uri(url);
                using (var response = await client.GetAsync("Reservation"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<Reservation>>(apiResponse);
                }
            }
            return View(list);
        }

        public async Task<IActionResult> CallApi()
        {
            string accessToken = await HttpContext.GetTokenAsync("access_token");

            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:55600/identity");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.SendAsync(request);
                if(response.StatusCode != HttpStatusCode.OK)
                {
                    return Content(response.ToString());
                }
                return Content($"{await response.Content.ReadAsStringAsync()}");
            }
        }

        // GET: ReservationClientController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var url = "https://localhost:44314/api/";
            Reservation reservation = new Reservation();
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization =new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.BaseAddress = new Uri(url);
                using (var response = await client.GetAsync("Reservation/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                }
            }
            return View(reservation);
        }

        // GET: ReservationClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservationClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            try
            {
                string url = "https://localhost:44314/api/Reservation";
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Authorization =new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                    StringContent content = new StringContent(JsonConvert.SerializeObject(reservation), System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        //xu ly loi
                        //return Content(response.ToString());
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var ret = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservationClientController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var url = "https://localhost:44314/api/";
            List<Reservation> list = new List<Reservation>();

            Reservation reservation = null;
            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.BaseAddress = new Uri(url);
                using (var response = await client.GetAsync("Reservation/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                }
            }
            return View(reservation);
        }

        // POST: ReservationClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Reservation reservation)
        {
            try
            {
                var url = "https://localhost:44314/api/Reservation/" + reservation.Id;
                List<Reservation> list = new List<Reservation>();
                using (var client = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(reservation), System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(url, content);
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        //xu ly loi
                        //return Content(response.ToString());
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var ret = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservationClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservationClientController/Delete/5
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
