using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDungNganHang.Helpers
{
    internal class PaymentDeadlineHelper
    {
        public static bool IsWithinDeadline(DateTime ngayVay, int kyHanThang, DateTime ngayTra)
        {
            var hanCuoi = ngayVay.AddMonths(kyHanThang);
            return ngayTra <= hanCuoi;
        }
    }
}
