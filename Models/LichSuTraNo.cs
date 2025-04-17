using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDungNganHang.Models
{
    internal class LichSuTraNo
    {
        [Key]
        public int MaTraNo { get; set; }

        [Required]
        [ForeignKey("KhoanVay")]
        public int MaKhoanVay { get; set; }

        public DateTime NgayTra { get; set; }

        public decimal SoTienTra { get; set; }

        public bool TrongHan { get; set; } 

        public string ? GhiChu { get; set; }

        // Navigation
        public int? MaUser { get; set; } // người thu nợ
        [ForeignKey("MaUser")]
        public virtual User? NguoiThuNo { get; set; }

        public virtual KhoanVay ? KhoanVay { get; set; }
    }
}
