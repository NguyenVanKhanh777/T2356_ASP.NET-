using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Banner
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Hình Ảnh")]
        public string? Image { get; set; }

        [Display(Name = "Tiêu Đề")]
        public string? Title { get; set; }

        [Display(Name = "Phụ Đề")]
        public string? SubTitle { get; set; }

        [Display(Name = "Liên Kết")]
        public string? Urls { get; set; }

        [Display(Name = "Thứ Tự")]
        public int Orders { get; set; }

        [Display(Name = "Loại Banner")]
        public string? Type { get; set; }

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
        public byte Status { get; set; }

        [Display(Name = "Đã Xóa")]
        public bool Isdelete { get; set; }
    }
}
