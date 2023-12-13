namespace BookManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "GenreId_Id", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "GenreId_Id" });
            RenameColumn(table: "dbo.Books", name: "GenreId_Id", newName: "GenreId");
            AlterColumn("dbo.Books", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "GenreId");
            AddForeignKey("dbo.Books", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "GenreId" });
            AlterColumn("dbo.Books", "GenreId", c => c.Int());
            RenameColumn(table: "dbo.Books", name: "GenreId", newName: "GenreId_Id");
            CreateIndex("dbo.Books", "GenreId_Id");
            AddForeignKey("dbo.Books", "GenreId_Id", "dbo.Genres", "Id");
        }
    }
}
