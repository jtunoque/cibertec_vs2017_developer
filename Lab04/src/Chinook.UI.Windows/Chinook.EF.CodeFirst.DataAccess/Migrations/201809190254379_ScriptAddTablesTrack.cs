namespace Chinook.EF.CodeFirst.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScriptAddTablesTrack : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlaylistTrack",
                c => new
                    {
                        PlaylistId = c.Int(nullable: false),
                        TrackId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlaylistId, t.TrackId })
                .ForeignKey("dbo.Track", t => t.TrackId, cascadeDelete: true)
                .ForeignKey("dbo.Playlist", t => t.PlaylistId, cascadeDelete: true)
                .Index(t => t.PlaylistId)
                .Index(t => t.TrackId);
            
            CreateTable(
                "dbo.Playlist",
                c => new
                    {
                        PlaylistId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 120),
                    })
                .PrimaryKey(t => t.PlaylistId);
            
            CreateTable(
                "dbo.Track",
                c => new
                    {
                        TrackId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 200),
                        Playlist_PlaylistId = c.Int(),
                    })
                .PrimaryKey(t => t.TrackId)
                .ForeignKey("dbo.Playlist", t => t.Playlist_PlaylistId)
                .Index(t => t.Playlist_PlaylistId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlaylistTrack", "PlaylistId", "dbo.Playlist");
            DropForeignKey("dbo.Track", "Playlist_PlaylistId", "dbo.Playlist");
            DropForeignKey("dbo.PlaylistTrack", "TrackId", "dbo.Track");
            DropIndex("dbo.Track", new[] { "Playlist_PlaylistId" });
            DropIndex("dbo.PlaylistTrack", new[] { "TrackId" });
            DropIndex("dbo.PlaylistTrack", new[] { "PlaylistId" });
            DropTable("dbo.Track");
            DropTable("dbo.Playlist");
            DropTable("dbo.PlaylistTrack");
        }
    }
}
