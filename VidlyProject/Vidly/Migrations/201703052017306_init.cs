namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            AddColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "ProductId", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Total");
            DropColumn("dbo.Orders", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Customer_Id", c => c.Int());
            AddColumn("dbo.Orders", "Total", c => c.Single(nullable: false));
            DropColumn("dbo.Orders", "ProductId");
            DropColumn("dbo.Orders", "CustomerId");
            CreateIndex("dbo.Orders", "Customer_Id");
            AddForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
