namespace WebTender.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tenders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOfTender = c.Int(nullable: false),
                        SubjectOfTender = c.String(nullable: false, maxLength: 50),
                        Discription = c.String(nullable: false, maxLength: 1000),
                        Organizer = c.Int(nullable: false),
                        TenderType = c.Int(nullable: false),
                        Category = c.Int(nullable: false),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Currency = c.Int(nullable: false),
                        PublicationDate = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tenders");
        }
    }
}
