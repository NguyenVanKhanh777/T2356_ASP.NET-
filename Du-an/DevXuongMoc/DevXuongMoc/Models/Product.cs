using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Product
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "ID Danh Mục")]
        public int? Cid { get; set; }

        [Display(Name = "Mã Sản Phẩm")]
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

        [Display(Name = "Từ Khóa Meta")]
        public string? MetaKeyword { get; set; }

        [Display(Name = "Mô Tả Meta")]
        public string? MetaDescription { get; set; }

        [Display(Name = "Slug")]
        public string? Slug { get; set; }

        [Display(Name = "Giá Cũ")]
        public decimal? PriceOld { get; set; }

        [Display(Name = "Giá Mới")]
        public decimal? PriceNew { get; set; }

        [Display(Name = "Kích Thước")]
        public string? Size { get; set; }

        [Display(Name = "Lượt Xem")]
        public int? Views { get; set; }

        [Display(Name = "Lượt Thích")]
        public int? Likes { get; set; }

        [Display(Name = "Đánh Giá")]
        public double? Star { get; set; }

        [Display(Name = "Trang Chủ")]
        public byte? Home { get; set; }

        [Display(Name = "Sản Phẩm Hot")]
        public byte? Hot { get; set; }

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
