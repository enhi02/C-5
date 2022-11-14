using Lab6.Interface;
using Lab6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.Services
{
    public class ReservationSvc : IReservation
    {
        private readonly DataContext _context;
        public ReservationSvc(DataContext context)
        {
            _context = context;
        }

        public Reservation Reservations(int id)
        {
            var reservation = _context.Reservations.Find(id);

            if (reservation == null)
            {
                return null;
            }
            return reservation;
        }

        public IEnumerable<Reservation> Reservations()
        {
            return _context.Reservations.ToList();
        }

        public Reservation AddReservation(Reservation reservation)
        {
            _context.Add(reservation);
            _context.SaveChanges();
            return reservation;
        }

        public void DeleteReservation(int id)
        {
            var reservation = _context.Reservations.Find(id);
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
        }

        public Reservation UpdateReservation([FromForm]Reservation reservation)
        {
            _context.Update(reservation);
            _context.SaveChanges();
            return reservation;
        }
    }
}
