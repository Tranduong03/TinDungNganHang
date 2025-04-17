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

        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<KhoanVay> KhoanVays { get; set; }
        public DbSet<LichSuTraNo> LichSuTraNos { get; set; }
        public DbSet<SoNo> SoNos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .HasIndex(k => k.CCCD)
                .IsUnique();

            base.OnModelCreating(modelBuilder);


        }
    }
}
