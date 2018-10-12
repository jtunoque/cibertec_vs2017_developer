namespace Chinook.EF.CodeFirst.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScriptAddTableAlbum : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Album",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ArtistId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlbumId)
                .ForeignKey("dbo.Artist", t => t.ArtistId, cascadeDelete: true)
                .Index(t => t.ArtistId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Album", "ArtistId", "dbo.Artist");
            DropIndex("dbo.Album", new[] { "ArtistId" });
            DropTable("dbo.Album");
        }
    }
}
