using GymManagement.Models;
using Microsoft.AspNetCore.Identity;

namespace GymManagement.Data
{
    public static class DbInitializer
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string[] roles = { "Admin", "Member" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            string adminEmail = "ogrencinumarasi@sakarya.edu.tr";
            string adminPassword = "sau";

            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true,
                    FullName = "Admin User"
                };

                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}
