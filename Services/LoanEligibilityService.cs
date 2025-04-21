using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinDungNganHang.Repositories;

namespace TinDungNganHang.Services
{
    internal class LoanEligibilityService
    {
        public static string CheckEligibility(int maKH)
        {
            using var context = new DataContext();
            var khachHang = context.KhachHangs.FirstOrDefault(kh => kh.MaKH == maKH);

            if (khachHang == null)
            {
                return "Customer not found";
            }

            // 1. Check tuổi
            int age = DateTime.Now.Year - khachHang.NgaySinh.Year;
            if (khachHang.NgaySinh > DateTime.Now.AddYears(-age)) age--;

            if (age < 18)
            {
                return "Under 18";
            }

            // 2. Check nợ cũ
            var khoanVays = context.KhoanVays.Where(kv => kv.MaKH == maKH).ToList();
            foreach (var kv in khoanVays)
            {
                var soNo = context.SoNos.FirstOrDefault(sn => sn.MaKhoanVay == kv.MaKhoanVay);
                if (soNo != null && soNo.ConNo > 0)
                {
                    return "Bad Debt";
                }
            }

            // 3. Nếu qua hết
            return "OK";
        }
    }
}
