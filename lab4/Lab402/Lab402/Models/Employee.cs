using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab402.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please enter name"), Display(Name = "Full Name")]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter emp.code"), Display(Name = "Emp. Code")]
        [Column(TypeName = "varchar(10)")]
        public string EmpCode { get; set; }

        [Required(ErrorMessage = "Please enter Position")]
        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please enter office location"), Display(Name = "Office Location")]
        [Column(TypeName = "varchar(100)")]
        public string OfficeLocation { get; set; }
    }
}
