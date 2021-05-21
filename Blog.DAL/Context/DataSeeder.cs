using Blog.ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAL.Context
{
	public class DataSeeder
	{
		public static async Task SeedUsersAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			if (!roleManager.Roles.Any())
			{
				await roleManager.CreateAsync(new IdentityRole("Admin"));
				await roleManager.CreateAsync(new IdentityRole("Editor"));
				await roleManager.CreateAsync(new IdentityRole("Moderator"));
				await roleManager.CreateAsync(new IdentityRole("Guest"));
			}

			if (!userManager.Users.Any())
			{
				var user1 = new ApplicationUser
				{
					Firstname = "Obafemi",
					Lastname = "Bankole",
					Email = "obahphemmy@gmail.com",
					UserName = "obahphemmy@gmail.com",
					ProfilePhotoUrl = "https://scontent-frt3-1.xx.fbcdn.net/v/t1.18169-9/29026482_991227424362594_1254365804794679262_n.jpg?_nc_cat=106&ccb=1-3&_nc_sid=8bfeb9&_nc_eui2=AeEu5gY0_76mrqb7r_NfcfE3yKgCia9Oy0DIqAKJr07LQLO-vo-YfP21rKHLH2xwXF0&_nc_ohc=xq54zwCFfwEAX8jkXTg&_nc_ht=scontent-frt3-1.xx&oh=84f4b55f6b4e939220e511b952852628&oe=60CA00F5"
				};

				await userManager.CreateAsync(user1, "pass");
				await userManager.AddToRoleAsync(user1, "Admin");

			}
		}

		public static async Task SeedCategoriesAsync(BlogDbContext context)
		{
			if (context.Categories.Any())
				return;

			var categories = new List<Category>()
			{
				new Category{ CategoryName = "Sports" },
				new Category{ CategoryName = "Politics" },
				new Category { CategoryName = "Technology" }
			};

			await context.Categories.AddRangeAsync(categories);
			await context.SaveChangesAsync();

		}
	}
}
