using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bai2.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Column(TypeName = "nvarchar(15)")]
        public string HoNV { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string TenLot { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string TenNV { get; set; }
        [Key]
        [Column(TypeName = "char(9)")]
       
        public string MaNV { get; set; }
       
        public DateTime NgaySinh { get; set; }
        [Column(TypeName = "nchar(30)")]
        public string DiaChi { get; set; }
        public string Phai { get; set; }
        public float luong { get; set; }
        [Column(TypeName = "char(9)")]
        public string Ma_NQL { get; set; }
        public int PHG { get; set; }
        public ICollection<ThanNhan> ThanNhans { get; set; }
    }
}
