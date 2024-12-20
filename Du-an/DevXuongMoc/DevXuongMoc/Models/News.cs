using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class News
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Mã Tin")]
        public string? Code { get; set; }

        [Display(Name = "Tiêu Đề")]
        public string? Title { get; set; }

        [Display(Name = "Mô Tả")]
        public string? Description { get; set; }

        [Display(Name = "Nội Dung")]
        public string? Content { get; set; }

        [Display(Name = "Hình Ảnh")]
        public string? Image { get; set; }

        [Display(Name = "Tiêu Đề Meta")]
        public string? MetaTitle { get; set; }

        [Display(Name = "Từ Khóa Chính")]
        public string? MainKeyword { get; set; }

        [Display(Name = "Từ Khóa Meta")]
        public string? MetaKeyword { get; set; }

        [Display(Name = "Mô Tả Meta")]
        public string? MetaDescription { get; set; }

        [Display(Name = "Slug")]
        public string? Slug { get; set; }

        [Display(Name = "Lượt Xem")]
        public int? Views { get; set; }

        [Display(Name = "Lượt Thích")]
        public int? Likes { get; set; }

        [Display(Name = "Đánh Giá")]
        public double? Star { get; set; }

        [Display(Name = "Ngày Tạo")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Ngày Cập Nhật")]
        public DateTime? UpdatedDate { get; set; }

        [Display(Name = "Quản Trị Tạo")]
        public string? AdminCreated { get; set; }

        [Display(Name = "Quản Trị Cập Nhật")]
        public string? AdminUpdated { get; set; }

        [Display(Name = "Trạng Thái")]
        public byte? Status { get; set; }

        [Display(Name = "Đã Xóa")]
        public bool? Isdelete { get; set; }
    }
}
