namespace MyResume.Data.Migrations.Seeders
{
    using System;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using MyResume.Common;
    using MyResume.Models;

    public class IdentitySeeder
    {
        public static void Seed(ApplicationDbContext databaseContext)
        {
            if (!databaseContext.Roles.Any(r => r.Name == GlobalConstants.AdminRole))
            {
                var store = new RoleStore<IdentityRole>(databaseContext);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = GlobalConstants.AdminRole };

                manager.Create(role);
            }

            // Change this ASAP
            if (!databaseContext.Users.Any(u => u.UserName == "admin@myresume.com"))
            {
                var store = new UserStore<ApplicationUser>(databaseContext);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser
                {
                    UserName = "admin@myresume.com",
                    Email = "admin@myresume.com",
                    CreatedOn = DateTime.Now,
                };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, GlobalConstants.AdminRole);
            }

            databaseContext.SaveChanges();
        }
    }
}
