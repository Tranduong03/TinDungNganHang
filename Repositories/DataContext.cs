using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinDungNganHang.Models;

namespace TinDungNganHang.Repositories
{
    internal class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection") { }

        public DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public DbSet<KhoanVay> KhoanVays { get; set; } = null!;
        public DbSet<LichSuTraNo> LichSuTraNos { get; set; } = null!;
        public DbSet<SoNo> SoNos { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .HasIndex(k => k.CCCD)
                .IsUnique();

            base.OnModelCreating(modelBuilder);


        }
    }
}
