using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fisrtWebApi.Models
{
    public class ReservationSvc : IReservation
    {
        private Dictionary<int, Reservation> items;

        public ReservationSvc()
        {
            items = new Dictionary<int, Reservation>();
            new List<Reservation>
            {
                new Reservation{ReservationId = 0, ClientName = "Thanh",Location="Lam Dong"},
                new Reservation{ReservationId = 1, ClientName = "Thanh2",Location="Lam Dong2"}
            }.ForEach(r => AddReservation(r));
            
        }
        public Reservation AddReservation(Reservation reservation)
        {
            if(reservation.ReservationId == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                reservation.ReservationId = key;
            }
            items[reservation.ReservationId] = reservation;
            return reservation;
        }

        public void DeleteReservation(int id)
        {
            items.Remove(id);
        }

        public Reservation EditReservation(Reservation reservation)
        {
            return AddReservation(reservation);
        }

        public Reservation findByID(int id)
        {
            if (items.ContainsKey(id))
                return items.ContainsKey(id) ? items[id] : null;
            else
                return null;
        }

        public IEnumerable<Reservation> GetReservations()
        {
            return items.Values.ToList() ;
        }
    }
}
