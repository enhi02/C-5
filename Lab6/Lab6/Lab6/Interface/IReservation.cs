using Lab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.Interface
{
    public interface IReservation
    { 
        Reservation Reservations(int id);
        IEnumerable<Reservation> Reservations();
        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);


    }
}
