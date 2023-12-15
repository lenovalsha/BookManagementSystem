namespace BookManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "FirstName", c => c.String());
            AddColumn("dbo.Authors", "LastName", c => c.String());
            AddColumn("dbo.Authors", "Address", c => c.String());
            AddColumn("dbo.Authors", "Email", c => c.String());
            AddColumn("dbo.Authors", "Phone", c => c.String());
            DropColumn("dbo.Authors", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "Name", c => c.String());
            DropColumn("dbo.Authors", "Phone");
            DropColumn("dbo.Authors", "Email");
            DropColumn("dbo.Authors", "Address");
            DropColumn("dbo.Authors", "LastName");
            DropColumn("dbo.Authors", "FirstName");
        }
    }
}
