using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDungNganHang.Models
{
    internal class KhachHang
    {
        [Key]
        public int MaKH { get; set; } 

        [Required]
        [StringLength(12)]
        public string ? CCCD { get; set; } 

        [Required]
        [StringLength(100)]
        public string ? HoTen { get; set; }

        [StringLength(200)]
        public string ? DiaChi { get; set; }

        [Phone]
        public string ? SoDienThoai { get; set; }

        public DateTime NgaySinh { get; set; }

        // Navigation
        public virtual ICollection<KhoanVay> ? KhoanVays { get; set; }
    }
}
