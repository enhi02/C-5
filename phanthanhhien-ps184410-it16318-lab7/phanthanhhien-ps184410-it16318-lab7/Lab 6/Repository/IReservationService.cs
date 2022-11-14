using Lab_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6.Repository
{
    public interface IReservationService
    {
        IEnumerable<Reservation> Reservations();
        Reservation ReservationsById(int id);
        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);      
    }
}
