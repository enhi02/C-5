using Lab_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6.Repository
{
    public class ReservationService : IReservationService
    {
        
        private readonly ReservationDBContext _context;
        public ReservationService(ReservationDBContext context)
        {           
            _context = context;
        }
        public IEnumerable<Reservation> Reservations()
        {
            return _context.Reservations.ToList();
        }

        public Reservation ReservationsById(int id)
        {
            var reservationGetById = _context.Reservations.Find(id);
            return reservationGetById;
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            return reservation;
        }

        public void DeleteReservation(int id)
        {
            var reservationId = _context.Reservations.Find(id);
            _context.Reservations.Remove(reservationId);
            _context.SaveChanges();
        }

        public Reservation UpdateReservation(Reservation reservation)
        {
            var reservationUpd = _context.Reservations.Find(reservation.Id);
            reservationUpd.Name = reservation.Name;
            reservationUpd.StartLocation = reservation.StartLocation;
            reservationUpd.EndLocation = reservation.EndLocation;
            _context.SaveChanges();
            return reservationUpd;
        }
    }
}
