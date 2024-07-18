using System.Linq;

namespace BlazorApp.Server.Models
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Check if there are any items already present
            if (context.Items.Any())
            {
                return; // DB has been seeded
            }

            // Seed the database with initial data
            var items = new[]
            {
                new Item { Name = "Item1" },
                new Item { Name = "Item2" },
                new Item { Name = "Item3" }
            };

            context.Items.AddRange(items);
            context.SaveChanges();
        }
    }
}
