using System;
using TinDungNganHang.Models;

namespace TinDungNganHang.Services
{
    public static class LoanCalculationService
    {
        internal static decimal CalculateTotalLoan(KhoanVay khoanVay)
        {
            if (khoanVay == null)
                throw new ArgumentNullException(nameof(khoanVay));

            decimal goc = khoanVay.SoTienVay;
            decimal laiSuat = (decimal)khoanVay.LaiSuat; 
            int kyHanThang = khoanVay.KyHanThang;

            decimal tongTien = goc + (goc * laiSuat / 100m * kyHanThang);
            return tongTien;
        }
    }
}
