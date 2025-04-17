using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDungNganHang.Models
{
    internal class SoNo
    {
        [Key]
        public int MaSoNo { get; set; }

        [ForeignKey("KhoanVay")]
        public int MaKhoanVay { get; set; }

        public decimal TongTienVay { get; set; }
        public decimal TongTienDaTra { get; set; }
        public decimal ConNo => TongTienVay - TongTienDaTra;

        // Navigation
        public virtual KhoanVay? KhoanVay { get; set; }
    }
}
