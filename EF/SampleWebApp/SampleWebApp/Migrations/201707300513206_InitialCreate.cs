namespace SampleWebApp.Migrations {
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration {
        public override void Up() {
            CreateTable(
                "dbo.TblPermits",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    User = c.String(),
                    Desc = c.String(),
                    CreateDate = c.DateTime(nullable: false),
                    ExpDate = c.DateTime(nullable: false),
                    Contractor = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down() {
            DropTable("dbo.TblPermits");
        }
    }
}
