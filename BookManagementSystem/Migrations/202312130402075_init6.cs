namespace BookManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init6 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BookAuthors");
            AddColumn("dbo.BookAuthors", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.BookAuthors", "AuthorId_Id", c => c.Int());
            AddColumn("dbo.BookAuthors", "BookId_Id", c => c.Int());
            AddPrimaryKey("dbo.BookAuthors", "Id");
            CreateIndex("dbo.BookAuthors", "AuthorId_Id");
            CreateIndex("dbo.BookAuthors", "BookId_Id");
            AddForeignKey("dbo.BookAuthors", "AuthorId_Id", "dbo.Authors", "Id");
            AddForeignKey("dbo.BookAuthors", "BookId_Id", "dbo.Books", "Id");
            DropColumn("dbo.BookAuthors", "BookId");
            DropColumn("dbo.BookAuthors", "AuthorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookAuthors", "AuthorId", c => c.Int(nullable: false));
            AddColumn("dbo.BookAuthors", "BookId", c => c.Int(nullable: false));
            DropForeignKey("dbo.BookAuthors", "BookId_Id", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "AuthorId_Id", "dbo.Authors");
            DropIndex("dbo.BookAuthors", new[] { "BookId_Id" });
            DropIndex("dbo.BookAuthors", new[] { "AuthorId_Id" });
            DropPrimaryKey("dbo.BookAuthors");
            DropColumn("dbo.BookAuthors", "BookId_Id");
            DropColumn("dbo.BookAuthors", "AuthorId_Id");
            DropColumn("dbo.BookAuthors", "Id");
            AddPrimaryKey("dbo.BookAuthors", new[] { "BookId", "AuthorId" });
        }
    }
}
