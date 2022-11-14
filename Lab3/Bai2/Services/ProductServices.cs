using System.Collections.Generic;
using Bai2.Models;
using Bai2.Interface;

namespace Bai2.Services
{
    public class ProductServices : IGetAllList
    {
        public List<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product() { Id = 1, Name ="HaHa"},
                new Product() { Id = 2, Name ="HiHi"},
                new Product(){ Id = 3, Name ="HuHu"}
            };
        }
    }
}
