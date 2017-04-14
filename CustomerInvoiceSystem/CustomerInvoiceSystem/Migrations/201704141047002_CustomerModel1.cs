namespace CustomerInvoiceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Phone");
        }
    }
}
