namespace BookManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookAuthors", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.BookAuthors", "BookId_Id", "dbo.Books");
            DropIndex("dbo.BookAuthors", new[] { "AuthorId" });
            DropIndex("dbo.BookAuthors", new[] { "BookId_Id" });
            DropTable("dbo.BookAuthors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorId = c.Int(nullable: false),
                        BookId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.BookAuthors", "BookId_Id");
            CreateIndex("dbo.BookAuthors", "AuthorId");
            AddForeignKey("dbo.BookAuthors", "BookId_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.BookAuthors", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
    }
}
