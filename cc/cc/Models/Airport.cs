using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cc.Models
{
    public class Airport
    {
        public int Id { get; set; }
        [InverseProperty("Depart")]
        public virtual ICollection<Flight> Departingflight { get; set; }
        [InverseProperty("Arrival")]

        public virtual ICollection<Flight> Arrivalingflight { get; set; }

        
    }
}
