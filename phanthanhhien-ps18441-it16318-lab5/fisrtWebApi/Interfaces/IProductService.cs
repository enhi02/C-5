using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fisrtWebApi.Models
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> getAll();
        ProductViewModel findByID(int id);
        ProductViewModel Add(ProductViewModel reservation);
        ProductViewModel Edit(ProductViewModel reservation);
        void Delete(int id);
    }
}
