namespace SampleWebApp.Migrations {
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SampleWebApp.Domain.Persistence.SampleContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SampleWebApp.Domain.Persistence.SampleContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            context.Permits.AddOrUpdate(new Domain.Core.TblPermits() {
                User = "test user",
                Contractor = "RDFI",
                CreateDate = DateTime.Now,
                ExpDate = DateTime.Now
            });

        }
    }
}
