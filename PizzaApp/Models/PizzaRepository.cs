using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PizzaApp.Models
{
    public class PizzaRepository: IPizzaRepository
    {
        // Access to the database
        private readonly ApplicationDbContext _db;

        // Constructor
        public PizzaRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Pizza> AllPizzas
        {
            get
            {
                return _db.Pizzas.Include(c => c.category);
            }
        }

        public IEnumerable<Pizza> PizzasOfTheWeek
        {
            get
            {
                return _db.Pizzas.Include(c => c.category).Where(p => p.IsPizzaOfTheWeek);
            }
        }

        public Pizza GetPizzaById(int pizzaId)
        {
            return _db.Pizzas.FirstOrDefault(p => p.PizzaId == pizzaId);
        }
    }
}
