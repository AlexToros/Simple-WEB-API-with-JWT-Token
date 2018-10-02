using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestAPI.Models
{
    public class DBSeeder
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDBContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            context.Database.EnsureCreated();
            if (context.Users.Count() == 0)
            {
                AppUser user = new AppUser()
                {
                    Email = "pyankov.work@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "Alex"
                };
                IdentityResult r = await userManager.CreateAsync(user, "Password@123");
                context.SaveChanges();
            }
        }
    }
}
