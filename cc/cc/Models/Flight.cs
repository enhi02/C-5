using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cc.Models
{
    public class Flight

    {
        public int Id { get; set; }
        public Airport Depart { get; set; }
        public Airport Arrival { get; set; }
    }
}
