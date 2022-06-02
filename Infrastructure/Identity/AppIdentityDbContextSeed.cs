using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Sender Flores",
                    Email = "safcrace@gmail.com",
                    UserName = "safcrace@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Sender",
                        LastName = "Flores",
                        Street = "Col. Santa Ana",
                        City = "Guatemala",
                        State = "Guatemala",
                        ZipCode = "01005",
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
