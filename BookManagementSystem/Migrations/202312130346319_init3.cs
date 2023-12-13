namespace BookManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "GenreId_Id", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "GenreId_Id" });
            DropColumn("dbo.Books", "GenreId_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "GenreId_Id", c => c.Int());
            CreateIndex("dbo.Books", "GenreId_Id");
            AddForeignKey("dbo.Books", "GenreId_Id", "dbo.Genres", "Id");
        }
    }
}
