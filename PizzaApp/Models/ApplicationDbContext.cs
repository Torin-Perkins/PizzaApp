using Microsoft.EntityFrameworkCore;

namespace PizzaApp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Filename=./pizzas.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Meat Pizzas", Description = "Pizzas with meat"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Veggie Pizzas", Description = "Pizzas with veggies"});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Vegetarian Pizzas", Description = "Pizzas with no meat" });
            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 1,
                Name = "Pepperoni Pizza",
                Price = 9.25M,
                ShortDescription = "Plain Old Pepperoni Pizza",
                LongDescription = "Large pepperoni pizza with american cheese comes with any dipping sauce",
                categoryId = 1,
                ImageUrl = "https://i.ibb.co/27J06fLd/Pop-Pizza-3-56.jpg",
                InStock = true,
                IsPizzaOfTheWeek = true,
                ImageThumbnailUrl = "https://i.ibb.co/27J06fLd/Pop-Pizza-3-56.jpg",
                AllergyInformation = "Contains Gluten, Eggs, Milk"
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 2, 
                Name = "Cheese Pizza",
                Price = 8.00M,
                ShortDescription = "Plain Old Cheese Pizza",
                LongDescription = "Large Cheese Pizza with american cheese, great for any occasion",
                categoryId = 3, 
                ImageUrl = "https://i.ibb.co/21s1vfny/classic-cheese-pizza-FT-RECIPE0422-31a2c938fc2546c9a07b7011658cfd05.jpg", 
                InStock = true,
                ImageThumbnailUrl = "https://i.ibb.co/21s1vfny/classic-cheese-pizza-FT-RECIPE0422-31a2c938fc2546c9a07b7011658cfd05.jpg", 
                IsPizzaOfTheWeek = true, 
                AllergyInformation = "Contains Gluten, Eggs, Milk"
            });

        }
        public DbSet <Pizza> Pizzas { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
