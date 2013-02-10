namespace DbLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adding_Customer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomersId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Created = c.DateTime(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CustomersId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
