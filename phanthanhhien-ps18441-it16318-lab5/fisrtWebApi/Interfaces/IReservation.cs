using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fisrtWebApi.Models
{
    public interface IReservation
    {
        IEnumerable<Reservation> GetReservations();
        Reservation findByID(int id);
        Reservation AddReservation(Reservation reservation);
        Reservation EditReservation(Reservation reservation);
        void DeleteReservation(int id);
    }
}
