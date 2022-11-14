using slide.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace slide.Services
{
    public interface IRepository
    {
        List<Reservation> GetList();
        Reservation Get(int id);
        Reservation Add(Reservation newreservation);
        Reservation Update(Reservation updateRevation);
        void DeleteReservation(int id);
    }
}
