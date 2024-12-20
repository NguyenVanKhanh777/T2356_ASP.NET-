using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class ProductImage
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "ID Sản Phẩm")]
        public int? Pid { get; set; }

        [Display(Name = "Hình Ảnh")]
        public string? Image { get; set; }
    }
}
