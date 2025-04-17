namespace TinDungNganHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKH = c.Int(nullable: false, identity: true),
                        CCCD = c.String(nullable: false, maxLength: 12),
                        HoTen = c.String(nullable: false, maxLength: 100),
                        DiaChi = c.String(maxLength: 200),
                        SoDienThoai = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaKH)
                .Index(t => t.CCCD, unique: true);
            
            CreateTable(
                "dbo.KhoanVays",
                c => new
                    {
                        MaKhoanVay = c.Int(nullable: false, identity: true),
                        MaKH = c.Int(nullable: false),
                        SoTienVay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NgayVay = c.DateTime(nullable: false),
                        KyHanThang = c.Int(nullable: false),
                        LaiSuat = c.Single(nullable: false),
                        DaDuyet = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaKhoanVay)
                .ForeignKey("dbo.KhachHangs", t => t.MaKH, cascadeDelete: true)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.LichSuTraNoes",
                c => new
                    {
                        MaTraNo = c.Int(nullable: false, identity: true),
                        MaKhoanVay = c.Int(nullable: false),
                        NgayTra = c.DateTime(nullable: false),
                        SoTienTra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TrongHan = c.Boolean(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.MaTraNo)
                .ForeignKey("dbo.KhoanVays", t => t.MaKhoanVay, cascadeDelete: true)
                .Index(t => t.MaKhoanVay);
            
            CreateTable(
                "dbo.SoNoes",
                c => new
                    {
                        MaSoNo = c.Int(nullable: false, identity: true),
                        MaKhoanVay = c.Int(nullable: false),
                        TongTienVay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TongTienDaTra = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MaSoNo)
                .ForeignKey("dbo.KhoanVays", t => t.MaKhoanVay, cascadeDelete: true)
                .Index(t => t.MaKhoanVay);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoNoes", "MaKhoanVay", "dbo.KhoanVays");
            DropForeignKey("dbo.LichSuTraNoes", "MaKhoanVay", "dbo.KhoanVays");
            DropForeignKey("dbo.KhoanVays", "MaKH", "dbo.KhachHangs");
            DropIndex("dbo.SoNoes", new[] { "MaKhoanVay" });
            DropIndex("dbo.LichSuTraNoes", new[] { "MaKhoanVay" });
            DropIndex("dbo.KhoanVays", new[] { "MaKH" });
            DropIndex("dbo.KhachHangs", new[] { "CCCD" });
            DropTable("dbo.SoNoes");
            DropTable("dbo.LichSuTraNoes");
            DropTable("dbo.KhoanVays");
            DropTable("dbo.KhachHangs");
        }
    }
}
