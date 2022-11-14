using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6._2.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string StartLocation { get; set; }

        [StringLength(150)]
        public string EndLocation { get; set; }
    }
}
