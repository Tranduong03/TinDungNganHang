using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDungNganHang.Models
{
    internal class KhoanVay
    {
        [Key]
        public int MaKhoanVay { get; set; }

        [Required]
        [ForeignKey("KhachHang")]
        public int MaKH { get; set; }

        public decimal SoTienVay { get; set; }

        public DateTime NgayVay { get; set; }

        public int KyHanThang { get; set; } 

        public float LaiSuat { get; set; } 

        public bool DaDuyet { get; set; } = false;

        // Navigation
        public int? MaUser { get; set; } // người duyệt
        [ForeignKey("MaUser")]
        public virtual User? NguoiDuyet { get; set; }

        public virtual KhachHang ? KhachHang { get; set; }
        public virtual ICollection<LichSuTraNo> ? LichSuTraNos { get; set; }
    }
}
