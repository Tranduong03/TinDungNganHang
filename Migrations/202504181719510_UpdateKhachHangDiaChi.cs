namespace TinDungNganHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateKhachHangDiaChi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHangs", "TenBoMe", c => c.String());
            AddColumn("dbo.KhachHangs", "SdtBoMe", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "SdtBoMe");
            DropColumn("dbo.KhachHangs", "TenBoMe");
        }
    }
}
