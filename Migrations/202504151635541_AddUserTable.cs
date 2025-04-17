namespace TinDungNganHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        MaUser = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        HoTen = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.MaUser);
            
            AddColumn("dbo.KhoanVays", "MaUser", c => c.Int());
            AddColumn("dbo.LichSuTraNoes", "MaUser", c => c.Int());
            CreateIndex("dbo.KhoanVays", "MaUser");
            CreateIndex("dbo.LichSuTraNoes", "MaUser");
            AddForeignKey("dbo.KhoanVays", "MaUser", "dbo.Users", "MaUser");
            AddForeignKey("dbo.LichSuTraNoes", "MaUser", "dbo.Users", "MaUser");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LichSuTraNoes", "MaUser", "dbo.Users");
            DropForeignKey("dbo.KhoanVays", "MaUser", "dbo.Users");
            DropIndex("dbo.LichSuTraNoes", new[] { "MaUser" });
            DropIndex("dbo.KhoanVays", new[] { "MaUser" });
            DropColumn("dbo.LichSuTraNoes", "MaUser");
            DropColumn("dbo.KhoanVays", "MaUser");
            DropTable("dbo.Users");
        }
    }
}
