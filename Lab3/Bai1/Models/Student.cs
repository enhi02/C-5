using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai1.Models
{
    public enum Gender
    {
        [Display(Name ="Nam")]
        Nam=1,
        [Display(Name ="Nữ")]
        Nu=2
    }
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(30,ErrorMessage =("Pls Enter The Name"))]
        public string Name { get; set; }
        [Required,Range(1,int.MaxValue,ErrorMessage ="Pls Choose Gender")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage ="The value is invalid")]
        [Display(Name ="Date of Birth")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BirthDay { get; set; }

        [Required(ErrorMessage ="The value is invalid")]
        [Display(Name ="Batch Time")]
        public TimeSpan BatchTime { get; set; }

        [Required(ErrorMessage ="Pls enter phone number")]
        [StringLength(15)]
        public string PhoneNo { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Pls enter email address")]
        public string EmailAdd { get; set; }
        [Required(ErrorMessage ="Pls enter website Url")]
        [Column(TypeName ="varchar(50)")]
        [Url]
        public string Url { get; set; }
        [Required(ErrorMessage ="Pls enter password")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "Pls enter retype password")]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("PassWord",ErrorMessage ="Password not matched")]
        public string RetypePass { get; set; }
    }
}
