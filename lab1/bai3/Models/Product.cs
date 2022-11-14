using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantiny { get; set; }
        public bool Status { get; set; }
    }
}
