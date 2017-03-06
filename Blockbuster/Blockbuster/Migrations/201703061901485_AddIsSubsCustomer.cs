namespace Blockbuster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubsCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedNewsLetter");
        }
    }
}
