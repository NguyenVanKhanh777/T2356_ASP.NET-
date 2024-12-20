using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Product
    {
        [Display(Name = "Mã sản phẩm")]
        public int Id { get; set; }

        [Display(Name = "Danh mục")]
        public int? Cid { get; set; }

        [Display(Name = "Mã")]
        public string? Code { get; set; }

        [Display(Name = "Tiêu đề")]
        public string? Title { get; set; }

        [Display(Name = "Mô tả")]
        public string? Description { get; set; }

        [Display(Name = "Nội dung")]
        public string? Content { get; set; }

        [Display(Name = "Hình ảnh")]
        public string? Image { get; set; }

        [Display(Name = "Meta Title")]
        public string? MetaTitle { get; set; }

        [Display(Name = "Meta Keyword")]
        public string? MetaKeyword { get; set; }

        [Display(Name = "Meta Description")]
        public string? MetaDescription { get; set; }

        [Display(Name = "Slug")]
        public string? Slug { get; set; }

        [Display(Name = "Giá cũ")]
        public decimal? PriceOld { get; set; }

        [Display(Name = "Giá mới")]
        public decimal? PriceNew { get; set; }

        [Display(Name = "Kích cỡ")]
        public string? Size { get; set; }

        [Display(Name = "Lượt xem")]
        public int? Views { get; set; }

        [Display(Name = "Lượt thích")]
        public int? Likes { get; set; }

        [Display(Name = "Đánh giá")]
        public double? Star { get; set; }

        [Display(Name = "Hiển thị trang chủ")]
        public byte? Home { get; set; }

        [Display(Name = "Sản phẩm hot")]
        public byte? Hot { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Ngày cập nhật")]
        public DateTime? UpdatedDate { get; set; }

        [Display(Name = "Người tạo")]
        public string? AdminCreated { get; set; }

        [Display(Name = "Người cập nhật")]
        public string? AdminUpdated { get; set; }

        [Display(Name = "Trạng thái")]
        public byte? Status { get; set; }

        [Display(Name = "Đã xóa")]
        public bool? Isdelete { get; set; }
    }
}
