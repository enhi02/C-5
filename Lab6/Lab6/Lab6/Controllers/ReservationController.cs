using Lab6.Interface;
using Lab6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private IReservation _reservation;

        public ReservationController(IReservation reservation)
        {
            _reservation = reservation;
        }

        [HttpGet]
        public IEnumerable<Reservation> Get()
        {
            return _reservation.Reservations();
        }

        [HttpGet("{id}")]
        public ActionResult<Reservation> Get(int id)
        {
            if (id == 0)
                return BadRequest("Value must be passed in the request body.");
            return Ok(_reservation.Reservations(id));
        }


        [HttpPost]
        public Reservation Post(Reservation res)
        => _reservation.AddReservation(new Reservation
           {
            Name = res.Name,
            StartLocation = res.StartLocation,
            EndLocation = res.EndLocation
            });




        public Reservation Put([FromBody] Reservation res)
       => _reservation.UpdateReservation(res);


        // DELETE api/<ReservationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        => _reservation.DeleteReservation(id);
    }
}
