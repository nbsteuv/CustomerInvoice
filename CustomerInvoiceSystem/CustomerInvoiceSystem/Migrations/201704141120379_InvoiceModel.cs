namespace CustomerInvoiceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InvoiceModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(nullable: false),
                        Description = c.String(),
                        DateSent = c.DateTime(nullable: false),
                        Paid = c.Boolean(nullable: false),
                        DatePaid = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "Invoice_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Invoice_Id");
            AddForeignKey("dbo.Orders", "Invoice_Id", "dbo.Invoices", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Invoice_Id", "dbo.Invoices");
            DropIndex("dbo.Orders", new[] { "Invoice_Id" });
            DropColumn("dbo.Orders", "Invoice_Id");
            DropTable("dbo.Invoices");
        }
    }
}
