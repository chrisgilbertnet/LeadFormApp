using LeadFormApp.Infrastructure;
using System.Data.Entity.Migrations;

namespace LeadFormApp.Infrasturcture.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LeadFormAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //ContextKey = "LeadFormApp.Infrastructure.LeadFormAppDbContext";
        }

        protected override void Seed(LeadFormAppDbContext context)
        {
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
        }
    }
}