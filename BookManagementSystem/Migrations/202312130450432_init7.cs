namespace BookManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init7 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Books", name: "Genre_Id", newName: "GenreId_Id");
            RenameIndex(table: "dbo.Books", name: "IX_Genre_Id", newName: "IX_GenreId_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Books", name: "IX_GenreId_Id", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Books", name: "GenreId_Id", newName: "Genre_Id");
        }
    }
}
