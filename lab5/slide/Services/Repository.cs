using slide.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace slide.Services
{
    public class Repository : IRepository
    {
        private List<Reservation>items =  new List<Reservation>() ;
        public Repository()
        {
            Reservation obj = new Reservation();
            obj.Id = 1;
            obj.Name = "long";
            obj.EndLoca = "123";
            obj.StartLoca = "HA noi";
            items.Add(obj);

            Reservation obj2 = new Reservation();
            obj.Id = 2;
            obj.Name = "123long";
            obj.EndLoca = "long123";
            obj.StartLoca = "HA noi";
            items.Add(obj2);
            //new List<Reservation>
            //{
            //    new Reservation {Id=1, Name = "Hienpt", StartLoca = "Ninh Thuan", EndLoca =     "HCM"},
            //    new Reservation {Id=2, Name = "FPT", StartLoca = "HCM", EndLoca = "HN"}
            //}.ForEach(r => AddReservation(r));
        }

        

        public Reservation Add(Reservation newreservation)
        {
            throw new NotImplementedException();
        }

        public Reservation AddReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public void DeleteReservation(int id)
        {
            throw new NotImplementedException();
        }

        public Reservation Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetList()
        {
            return items;
        }

        public Reservation Update(Reservation updateRevation)
        {
            throw new NotImplementedException();
        }

        public Reservation UpdateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
