using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinDungNganHang.Models;

namespace TinDungNganHang.Services
{
    internal static class Session
    {
        public static User ? CurrentUser { get; set; }
    }
}
