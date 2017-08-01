namespace SampleWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblPermits", "Col1", c => c.String());
            AddColumn("dbo.TblPermits", "Col2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblPermits", "Col2");
            DropColumn("dbo.TblPermits", "Col1");
        }
    }
}
