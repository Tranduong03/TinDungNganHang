using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDungNganHang.Models
{
    internal class User
    {
        [Key]
        public int MaUser { get; set; }

        [Required]
        [MaxLength(50)]
        public string ? Username { get; set; }

        [Required]
        public string ? Password { get; set; }

        [Required]
        [MaxLength(100)]
        public string ? HoTen { get; set; }

        public virtual ICollection<KhoanVay>? KhoanVaysDuyet { get; set; }
        public virtual ICollection<LichSuTraNo>? LichSuThuNo { get; set; }
    }
}
