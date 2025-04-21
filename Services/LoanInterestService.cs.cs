using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDungNganHang.Services
{
    internal class LoanInterestService
    {
        public static decimal GetInterestRate(int months)
        {
            switch (months)
            {
                case 0:
                    return 0.0m;
                case 6:
                    return 5.0m;
                case 9:
                    return 6.0m;
                case 12:
                    return 9.0m;
                case 24:
                    return 12.0m;
                default:
                    return 15.0m; 
            }
        }
    }
}
