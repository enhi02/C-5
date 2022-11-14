using Lab_6.Models;
using Lab_6.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
       
        public string baseUrl = "https://localhost:44318";
        private readonly IConfiguration _configuration;
        public HomeController(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var client = _httpClientFactory.CreateClient("API");
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"{baseUrl}/api/reservation");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return View(JsonConvert.DeserializeObject<List<Reservation>>(body));
            else
                return RedirectToAction("Login");
        }

        public ViewResult GetReservationById() => View();
        [HttpPost]
        public async Task<IActionResult> GetReservationById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"{baseUrl}/api/reservation/{id}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return View(JsonConvert.DeserializeObject<Reservation>(body));
            }

            ModelState.TryAddModelError("", "Khong co Id nay");
            return View();
        }
        public ViewResult CreateReservation() => View();
        [HttpPost]
        public async Task<IActionResult> CreateReservation(Reservation reservation)
        {
            var client = _httpClientFactory.CreateClient();
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var json = JsonConvert.SerializeObject(reservation);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{baseUrl}/api/reservation", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return RedirectToAction("GetAll", JsonConvert.DeserializeObject<Reservation>(body));

            return View();
        }

        public async Task<IActionResult> UpdateReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var response = await client.GetAsync($"{baseUrl}/api/reservation/{id}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return View(JsonConvert.DeserializeObject<Reservation>(body));

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateReservation([FromRoute]int id,Reservation reservation)
        {
            var client = _httpClientFactory.CreateClient();
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var Content = new MultipartFormDataContent();
            //Content.Add(new StringContent(reservation.Id.ToString()), "Id");
            Content.Add(new StringContent(reservation.Name), "Name");
            Content.Add(new StringContent(reservation.StartLocation), "StartLocation");
            Content.Add(new StringContent(reservation.EndLocation), "EndLocation");
            var response = await client.PutAsync($"{baseUrl}/api/reservation/" + id, Content);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return RedirectToAction("GetAll",JsonConvert.DeserializeObject<Reservation>(body));

            return View();
        }

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var client = _httpClientFactory.CreateClient();
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var response = await client.DeleteAsync($"{baseUrl}/api/reservation/" + id);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return RedirectToAction("GetAll", JsonConvert.DeserializeObject<Reservation>(body));

            return View();
        }

        public ViewResult Login() => View();
        [HttpPost]
        public async Task<IActionResult> Login(UserInfo user)
        {
            var client = _httpClientFactory.CreateClient();
            var Content = new MultipartFormDataContent();

            Content.Add(new StringContent(user.Email), "Email");
            Content.Add(new StringContent(user.Password), "Password");
            var response = await client.PostAsync($"{baseUrl}/api/token", Content);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                HttpContext.Session.SetString("Token", body);
                return RedirectToAction("GetAll");
            }
            return View();
        }
    }
}
