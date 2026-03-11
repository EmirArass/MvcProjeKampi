namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Headings", "WriterID", "dbo.Writers");
            DropForeignKey("dbo.Contents", "HeadingID", "dbo.Headings");
            DropIndex("dbo.Contents", new[] { "WriterID" });
            AlterColumn("dbo.Contents", "WriterID", c => c.Int());
            CreateIndex("dbo.Contents", "WriterID");
            AddForeignKey("dbo.Headings", "WriterID", "dbo.Writers", "WriterID", cascadeDelete: true);
            AddForeignKey("dbo.Contents", "HeadingID", "dbo.Headings", "HeadingID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "HeadingID", "dbo.Headings");
            DropForeignKey("dbo.Headings", "WriterID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriterID" });
            AlterColumn("dbo.Contents", "WriterID", c => c.Int(nullable: false));
            CreateIndex("dbo.Contents", "WriterID");
            AddForeignKey("dbo.Contents", "HeadingID", "dbo.Headings", "HeadingID");
            AddForeignKey("dbo.Headings", "WriterID", "dbo.Writers", "WriterID");
        }
    }
}
