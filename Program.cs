using System.Data.Entity;
using TinDungNganHang.Repositories;

namespace TinDungNganHang.Forms.Auth
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var context = new DataContext())
            {
                SeedData.Seed(context);
            }


            // Khởi tạo CSDL nếu chưa có
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
            // Chỉ tạo lại nếu model thay đổi (dùng tốt khi đang phát triển)
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}