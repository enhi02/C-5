using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fisrtWebApi.Models
{
    public class ProductService : IProductService
    {
        private Dictionary<int, ProductViewModel> items;
        public ProductService()
        {
            items = new Dictionary<int, ProductViewModel>();
            new List<ProductViewModel>
            {
                new ProductViewModel{Id = 1,Name="Pen Drive"},
                new ProductViewModel{Id = 2,Name="Money Card"},
                new ProductViewModel{Id = 3,Name="Mobile Phone"},
                new ProductViewModel{Id = 4,Name="Tablet"},
                new ProductViewModel{Id = 5,Name="Desktop PC"},
            }.ForEach(r => Add(r));
        }

        public ProductViewModel Add(ProductViewModel reservation)
        {
            if (reservation.Id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                reservation.Id = key;
            }
            items[reservation.Id] = reservation;
            return reservation;
        }

        public void Delete(int id)
        {
            items.Remove(id);
        }

        public ProductViewModel Edit(ProductViewModel reservation)
        {
            return Add(reservation);
        }

        public ProductViewModel findByID(int id)
        {
            if (items.ContainsKey(id))
                return items.ContainsKey(id) ? items[id] : null;
            else
                return null;
        }

        public IEnumerable<ProductViewModel> getAll()
        {
            return items.Values.ToList();
        }
    }
}
