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
        public DbSet <Pizza> Pizzas { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
