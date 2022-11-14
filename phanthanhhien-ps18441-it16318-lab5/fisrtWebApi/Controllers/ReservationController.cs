using fisrtWebApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fisrtWebApi.Controllers
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

        // GET: api/<ReservatioinController>
        [HttpGet]
        public IEnumerable<Reservation> Get()
        {
            return _reservation.GetReservations();
        }

        // GET api/<ReservatioinController>/5
        [HttpGet("{id}")]
        public ActionResult<Reservation> Get(int id)
        {
            if (id != 0)
                return _reservation.findByID(id);
            else
                return BadRequest("Value must be passed in the request body.");
        }

        // POST api/<ReservatioinController>
        [HttpPost]
        public void Post([FromBody] Reservation res)
        {
            _reservation.AddReservation(new Reservation
            {
                ClientName = res.ClientName,
                Location = res.Location,
                ReservationId = res.ReservationId
            });
        }

        // PUT api/<ReservatioinController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Reservation res)
        {
            _reservation.EditReservation(res);
        }
        [HttpPatch("{id}")]
        public StatusCodeResult Patch(int id,[FromForm] JsonPatchDocument<Reservation> patch)
        {
            var res = (Reservation)((OkObjectResult)Get(id).Result).Value;
            if(res != null)
            {
                patch.ApplyTo(res);
                return Ok();
            }
            return NotFound();
        }
        // DELETE api/<ReservatioinController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _reservation.DeleteReservation(id);
        }
    }
}
