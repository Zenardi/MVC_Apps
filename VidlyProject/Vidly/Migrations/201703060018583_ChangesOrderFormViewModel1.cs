namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesOrderFormViewModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderFormViewModels", "ReferenceDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.OrderFormViewModels", "CustomerName", c => c.String());
            AddColumn("dbo.OrderFormViewModels", "ProductName", c => c.String());
            AddColumn("dbo.OrderFormViewModels", "ProductUnitCost", c => c.Single(nullable: false));
            AddColumn("dbo.OrderFormViewModels", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.OrderFormViewModels", "TotalValue", c => c.Single(nullable: false));
            DropColumn("dbo.OrderFormViewModels", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderFormViewModels", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.OrderFormViewModels", "TotalValue");
            DropColumn("dbo.OrderFormViewModels", "Quantity");
            DropColumn("dbo.OrderFormViewModels", "ProductUnitCost");
            DropColumn("dbo.OrderFormViewModels", "ProductName");
            DropColumn("dbo.OrderFormViewModels", "CustomerName");
            DropColumn("dbo.OrderFormViewModels", "ReferenceDate");
        }
    }
}
