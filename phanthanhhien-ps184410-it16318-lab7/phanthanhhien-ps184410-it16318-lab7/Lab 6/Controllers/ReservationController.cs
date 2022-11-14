using Lab_6.Models;
using Lab_6.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public IEnumerable<Reservation> GetAll()
        {
            return _reservationService.Reservations();
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var getid = _reservationService.ReservationsById(id);
            if(getid == null)
            {
                return BadRequest("Khong tim thay Id");
            }
            return Ok(getid);
        }

        [HttpPost]
        public ActionResult Create(Reservation reservation)
        {
            var param = new Reservation()
            {
                Name = reservation.Name,
                StartLocation = reservation.StartLocation,
                EndLocation = reservation.EndLocation
            };

            _reservationService.AddReservation(param);
            return Ok();
        }

        [HttpPut("{id}")]
        public Reservation Update(int id,[FromForm] Reservation reservation)
        {
            reservation.Id = id;
            return _reservationService.UpdateReservation(reservation);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _reservationService.DeleteReservation(id);
        }
    }
}
