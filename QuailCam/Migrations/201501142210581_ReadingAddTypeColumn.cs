namespace QuailCam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReadingAddTypeColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Readings", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Readings", "Type");
        }
    }
}
