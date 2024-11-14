using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_NET.Models
{
    public class People
    {
        public int Id { get; set; }
        [Display(Name="Ho va ten ")]
        public string Name { get; set; }

        [Display(Name = "Dia chi Email ")]
        public string Email { get; set; }

        [Display(Name = "So dien thoai ")]
        public string Phone { get; set; }

        [Display(Name = "Dia chi noi o ")]
        public string Address { get; set; }

        [Display(Name = "Anh dai dien ")]
        public string Avatar { get; set; }

        [Display(Name = "Ngay sinh nhat ")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Gioi thieu ban than ")]
        public string Bio { get; set; }

        [Display(Name = "gioi tinh ")]
        public byte Gender { get; set; }
    }
}
