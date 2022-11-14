﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMonAn.Models.ViewModels
{
    public class FoodViewModel : EditImageViewModel
    {
        public int MonAnId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Nhập Tên Món Ăn"), Display(Name = "Tên Món Ăn")]
        public string TenMonAn { get; set; }

        [Required(ErrorMessage = "Nhập Giá Món Ăn"), Display(Name = "Đơn Giá")]
        [Column(TypeName = "Money")]
        public double GiaMonAn { get; set; }


        [Range(1, int.MaxValue)]
        [Display(Name = "Số Lượng")]
        public string SoLuong { get; set; }

        //[Required(ErrorMessage = "Nhập Tên Ảnh"), Display(Name = "Hình Ảnh")]
        //[Column(TypeName = "varchar(200)"), MaxLength(100)]
        //public string Image { get; set; }

        //[NotMapped]
        //[Display(Name = "Chọn Hình")]
        //[DataType(DataType.Upload)]

        //public IFormFile ImageFile { get; set; }



        [Required(ErrorMessage = "Mô Tả Món Ăn"), Display(Name = "Mô Tả")]
        [StringLength(300)]
        public string MoTa { get; set; }

        [ForeignKey("categoryModel")]
        [Required(ErrorMessage = "Chọn Thể Loại"), Display(Name = "Thể Loại")]
        public int Category { get; set; }

        [Required(ErrorMessage = "Trạng Thái Món Ăn"), Display(Name = "Trạng Thái")]
        public bool TrangThai { get; set; }

        public bool IsDelete { get; set; }

        [Display(Name = "Thể Loại")]
        public CategoryModel categoryModel { get; set; }
    }
}
