using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAL.Entities
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("admin"));
        }

        public static async Task SeedAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultAdmin = new ApplicationUser()
            {
                UserName = "UsernamePlaceholder",
                Email = "EmailPlaceholder",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (!userManager.Users.Any(u => u.Id == defaultAdmin.Id))
            {
                if (!userManager.Users.Any(u => u.UserName == defaultAdmin.UserName))
                {
                    await userManager.CreateAsync(defaultAdmin, "PasswordPlaceholder");
                    await userManager.AddToRoleAsync(defaultAdmin, "admin");
                }
            }
        }
    }
}
