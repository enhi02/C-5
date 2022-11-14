using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Please enter name"), Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter skills"), Display(Name = "Skills")]
        [StringLength(30)]
        public string Skills { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter total student")]
        [Display(Name = "Total students")]
        public int TotalStudents { get; set; }

        [Required(ErrorMessage = "Please enter salary")]
        [Column(TypeName = "Money")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "The value is invalid"), Display(Name = "Day of Add")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime AddOn { get; set; }
    }
}
