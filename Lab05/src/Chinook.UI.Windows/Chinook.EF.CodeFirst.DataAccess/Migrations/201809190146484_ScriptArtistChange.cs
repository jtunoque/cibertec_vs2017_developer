namespace Chinook.EF.CodeFirst.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScriptArtistChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Artist", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Artist", "Name", c => c.String());
        }
    }
}
