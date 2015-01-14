namespace QuailCam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReadingAddTimestampColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Readings", "UtcTimestamp", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Readings", "UtcTimestamp");
        }
    }
}
