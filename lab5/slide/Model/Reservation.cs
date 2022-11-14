using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace slide.Model
{
    public class Reservation 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartLoca { get; set; }
        public string EndLoca { get; set; }
    }
}
