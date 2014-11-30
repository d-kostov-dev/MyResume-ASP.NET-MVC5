namespace MyResume.Data.Migrations
{
    using System.Data.Entity.Migrations;

    using MyResume.Data.Migrations.Seeders;
    
    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MyResume.Data.ApplicationDbContext context)
        {
            IdentitySeeder.Seed(context);

            // Just in case i don't save in any of the seeders
            context.SaveChanges();
        }
    }
}
