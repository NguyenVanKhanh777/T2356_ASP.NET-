using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Category
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Tiêu Đề")]
        public string? Title { get; set; }

        [Display(Name = "Biểu Tượng")]
        public string? Icon { get; set; }

        [Display(Name = "Tiêu Đề Meta")]
        public string? MateTitle { get; set; }

        [Display(Name = "Từ Khóa Meta")]
        public string? MetaKeyword { get; set; }

        [Display(Name = "Mô Tả Meta")]
        public string? MetaDescription { get; set; }

        [Display(Name = "Slug (Đường Dẫn)")]
        public string? Slug { get; set; }

        [Display(Name = "Thứ Tự")]
        public int? Orders { get; set; }

        [Display(Name = "ID Danh Mục Cha")]
        public int? Parentid { get; set; }

        [Display(Name = "Ngày Tạo")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Ngày Cập Nhật")]
        public DateTime? UpdatedDate { get; set; }

        [Display(Name = "Quản Trị Tạo")]
        public string? AdminCreated { get; set; }

        [Display(Name = "Quản Trị Cập Nhật")]
        public string? AdminUpdated { get; set; }

        [Display(Name = "Ghi Chú")]
        public string? Notes { get; set; }

        [Display(Name = "Trạng Thái")]
        public byte? Status { get; set; }

        [Display(Name = "Đã Xóa")]
        public bool? Isdelete { get; set; }
    }
}
