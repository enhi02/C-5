using Lab6._2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lab6._2.Controllers
{
    public class ReservationController : Controller
    {
        public ReservationController()
        {

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //var url = "https://" + Request.Host + "/api/";
            string accessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJTZWN1cmVBcGlXaXRoQWNlc3NUb2tlbiIsImp0aSI6IjY0NWI0NmEwLTRiZjYtNDNiYy1iNmE5LWUxYjA3OGNjNWY0NSIsImlhdCI6IjYvMTEvMjAyMSAxMjo0Nzo1NiBQTSIsIklkIjoiMSIsIkZ1bGxOYW1lIjoiUGh1b25nIER1bmciLCJFbWFpbCI6ImNoaW5oY2h1QGdtYWlsLmNvbSIsImV4cCI6MTYyMzUwMjA3NiwiaXNzIjoiU2VjdXJlU2VydmVyQXBpIiwiYXVkIjoiU2VjdXJlQXBpQ2xpZW50In0.60wbH0Pspt3R-Iy7hSl-XpFE_03w8vOiHSNZ3fNS9DQ";
            var url = "https://localhost:44368/api/reservations";
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
        public async Task<IActionResult> Details(int id)
        {
            var url = "https://localhost:44368/api/reservations";
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
        public ViewResult GetReservation() => View();
        [HttpPost]
        public async Task<IActionResult> GetReservation(int id)
        {
            Reservation reservation = new Reservation();
            using (var httpClient = new HttpClient())
            {
                using ( var response = await httpClient.GetAsync("https://localhost:44368/api/reservations" + id))
                {
                    if(response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        reservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);

                    }
                    else
                    {
                        ViewBag.StatusCode = response.StatusCode;
                    }
                }
            }
            return View(reservation);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            try
            {
                string url = "https://localhost:44368/api/reservations";
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

        public async Task<IActionResult> Edit(int id)
        {
            var url = "https://localhost:44368/api/reservations";
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

        // POST: ReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Reservation reservation)
        {
            try
            {
                var url = "https://localhost:44368/api/reservations" + reservation.Id;
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
    }
}
