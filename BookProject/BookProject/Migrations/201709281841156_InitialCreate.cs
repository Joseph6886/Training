namespace BookProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.paperbacks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ISBNNumber = c.Int(nullable: false),
                        Title = c.String(),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.paperbacks");
        }
    }
}
