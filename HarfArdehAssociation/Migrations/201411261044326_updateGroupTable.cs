namespace HarfArdehAssociation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateGroupTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Group", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Group", "FirstName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Group", "FirstName", c => c.String(nullable: false));
            DropColumn("dbo.Group", "Name");
        }
    }
}
