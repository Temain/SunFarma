namespace SunFarma.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CountryId = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        StreetId = c.Int(nullable: false),
                        HouseNumber = c.String(),
                        BuildingNumber = c.String(),
                        PostalCode = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .ForeignKey("dbo.Streets", t => t.StreetId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.RegionId)
                .Index(t => t.CityId)
                .Index(t => t.StreetId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityCode = c.String(),
                        CityName = c.String(),
                        CityFullName = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                        CountryFullName = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Int(nullable: false, identity: true),
                        RegionCode = c.String(),
                        RegionName = c.String(),
                        RegionFullName = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RegionId);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        StreetId = c.Int(nullable: false, identity: true),
                        StreetCode = c.String(),
                        StreetName = c.String(),
                        StreetFullName = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StreetId);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        AreaId = c.Int(nullable: false, identity: true),
                        AreaCode = c.String(),
                        AreaName = c.String(),
                        AreaFullName = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AreaId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        PriceReestId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Sum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        PriceReestr_PriceReestrId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.PriceReestrs", t => t.PriceReestr_PriceReestrId)
                .Index(t => t.PriceReestr_PriceReestrId);
            
            CreateTable(
                "dbo.PriceReestrs",
                c => new
                    {
                        PriceReestrId = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(),
                        ProductName = c.String(),
                        Maker = c.String(),
                        PriceId = c.Int(nullable: false),
                        Tax = c.Decimal(precision: 18, scale: 2),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Left = c.Int(nullable: false),
                        DifferencePercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LeaderPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reting = c.Int(nullable: false),
                        TotalPos = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PriceReestrId)
                .ForeignKey("dbo.Prices", t => t.PriceId, cascadeDelete: true)
                .Index(t => t.PriceId);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        PriceId = c.Int(nullable: false, identity: true),
                        PriceName = c.String(),
                        PriceTitle = c.String(),
                        LastPerform = c.DateTime(),
                        IsActual = c.Boolean(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        PriceLink = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PriceId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                        SupplierTitle = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        AddressId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierId)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderStatus = c.Int(nullable: false),
                        ApplicationUserId = c.String(maxLength: 128),
                        SupplierId = c.Int(nullable: false),
                        SentDate = c.DateTime(),
                        ReceiveDate = c.DateTime(nullable: false),
                        Positions = c.Int(nullable: false),
                        TotalSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaybillId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Waybills", t => t.WaybillId, cascadeDelete: true)
                .Index(t => t.ApplicationUserId)
                .Index(t => t.SupplierId)
                .Index(t => t.WaybillId);
            
            CreateTable(
                "dbo.Waybills",
                c => new
                    {
                        WaybillId = c.Int(nullable: false, identity: true),
                        DocumentNumber = c.Int(nullable: false),
                        DocumentDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        SentDate = c.DateTime(),
                        ReceiveDate = c.DateTime(nullable: false),
                        DocumentLink = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WaybillId);
            
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "MiddleName", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "WaybillId", "dbo.Waybills");
            DropForeignKey("dbo.Orders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Orders", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDetails", "PriceReestr_PriceReestrId", "dbo.PriceReestrs");
            DropForeignKey("dbo.Prices", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Suppliers", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.PriceReestrs", "PriceId", "dbo.Prices");
            DropForeignKey("dbo.Addresses", "StreetId", "dbo.Streets");
            DropForeignKey("dbo.Addresses", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Addresses", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropIndex("dbo.Orders", new[] { "WaybillId" });
            DropIndex("dbo.Orders", new[] { "SupplierId" });
            DropIndex("dbo.Orders", new[] { "ApplicationUserId" });
            DropIndex("dbo.Suppliers", new[] { "AddressId" });
            DropIndex("dbo.Prices", new[] { "SupplierId" });
            DropIndex("dbo.PriceReestrs", new[] { "PriceId" });
            DropIndex("dbo.OrderDetails", new[] { "PriceReestr_PriceReestrId" });
            DropIndex("dbo.Addresses", new[] { "StreetId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropIndex("dbo.Addresses", new[] { "RegionId" });
            DropIndex("dbo.Addresses", new[] { "CountryId" });
            DropColumn("dbo.AspNetUsers", "MiddleName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropTable("dbo.Waybills");
            DropTable("dbo.Orders");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Prices");
            DropTable("dbo.PriceReestrs");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Areas");
            DropTable("dbo.Streets");
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}
