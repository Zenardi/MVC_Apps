namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesOrderFormViewModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderFormViewModels", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.OrderFormViewModels", "Product_Id", "dbo.Products");
            DropIndex("dbo.OrderFormViewModels", new[] { "Customer_Id" });
            DropIndex("dbo.OrderFormViewModels", new[] { "Product_Id" });
            DropColumn("dbo.OrderFormViewModels", "Quantity");
            DropColumn("dbo.OrderFormViewModels", "Customer_Id");
            DropColumn("dbo.OrderFormViewModels", "Product_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderFormViewModels", "Product_Id", c => c.Int());
            AddColumn("dbo.OrderFormViewModels", "Customer_Id", c => c.Int());
            AddColumn("dbo.OrderFormViewModels", "Quantity", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderFormViewModels", "Product_Id");
            CreateIndex("dbo.OrderFormViewModels", "Customer_Id");
            AddForeignKey("dbo.OrderFormViewModels", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.OrderFormViewModels", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
