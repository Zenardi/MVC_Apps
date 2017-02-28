namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorNames : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NewOrderViewModels", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.NewOrderViewModels", "Product_Id", "dbo.Products");
            DropIndex("dbo.NewOrderViewModels", new[] { "Customer_Id" });
            DropIndex("dbo.NewOrderViewModels", new[] { "Product_Id" });
            CreateTable(
                "dbo.OrderFormViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Customer_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Product_Id);
            
            DropTable("dbo.NewOrderViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.NewOrderViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.OrderFormViewModels", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderFormViewModels", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.OrderFormViewModels", new[] { "Product_Id" });
            DropIndex("dbo.OrderFormViewModels", new[] { "Customer_Id" });
            DropTable("dbo.OrderFormViewModels");
            CreateIndex("dbo.NewOrderViewModels", "Product_Id");
            CreateIndex("dbo.NewOrderViewModels", "Customer_Id");
            AddForeignKey("dbo.NewOrderViewModels", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.NewOrderViewModels", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
