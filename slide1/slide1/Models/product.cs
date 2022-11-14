using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace slide1.Models
{
    public class product
    {
        public int id { get; set; }
        [Column(TypeName = "varchar(250")]
        public string name { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int Quantiny { get; set; }
        public bool Satus { get; set; }
    }
}
