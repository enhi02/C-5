using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_6.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string StartLocation { get; set; }
        [BindProperty]
        public string EndLocation { get; set; }
    }
}
