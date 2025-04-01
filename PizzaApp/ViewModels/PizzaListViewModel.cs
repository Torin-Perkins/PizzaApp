using PizzaApp.Models;

namespace PizzaApp.ViewModels
{
    public class PizzaListViewModel
    {
        public IEnumerable<Pizza> Pizzas { get; set; }
        public string CurrentCategory { get; set; }
    }
}
