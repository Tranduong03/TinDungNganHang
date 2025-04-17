using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinDungNganHang.Models;

namespace TinDungNganHang.Repositories
{
    internal class SeedData
    {
        public static void Seed(DataContext context)
        {
            // Seed User
            if (!context.Users.Any(u => u.Username == "admin"))
            {
                context.Users.Add(new User
                {
                    Username = "admin",
                    Password = "admin", 
                    HoTen = "admin"
                });

                context.SaveChanges();
            }

            // Các seed dữ liệu khác có thể thêm tại đây
        }
    }
}
