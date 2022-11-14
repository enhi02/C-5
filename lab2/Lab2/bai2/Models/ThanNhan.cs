using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bai2.Models
{
    [Table("ThanNHan")]
    public class ThanNhan
    {
       [Key]
        [Column(TypeName = "char(9)")]
        public string MaNVien { get; set; }
        [Key]
        [Column(TypeName = "nvarchar(15)")]
        public string TenTN { get; set; }
        [Column(TypeName = "nchar(3)")]
        public string Phai { get; set; }
        public DateTime NgSinh { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string QuanHe {get;set;}
        
    }
}
