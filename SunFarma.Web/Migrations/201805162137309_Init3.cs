namespace SunFarma.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "AreaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Addresses", "AreaId");
            AddForeignKey("dbo.Addresses", "AreaId", "dbo.Areas", "AreaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "AreaId", "dbo.Areas");
            DropIndex("dbo.Addresses", new[] { "AreaId" });
            DropColumn("dbo.Addresses", "AreaId");
        }
    }
}
