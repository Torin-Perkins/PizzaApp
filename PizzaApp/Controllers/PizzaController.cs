using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;
using PizzaApp.ViewModels;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PizzaController(IPizzaRepository pizzaRepository, ICategoryRepository categoryRepository)
        {
            _pizzaRepository = pizzaRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            //Instantiate the Pizza View Model
            PizzaListViewModel pizzaListViewModel = new PizzaListViewModel();
            // Fill in the pizza's data point of the view model from the repository
            pizzaListViewModel.Pizzas = _pizzaRepository.AllPizzas;
            // Fill in the category data popint of the view model from the repository
            pizzaListViewModel.CurrentCategory = "Meat Pizza";

            // return the view
            return View(pizzaListViewModel);
        }
        public IActionResult Details(int id)
        {
            // gets the pizza by its id from the repository and assigns to a variable to use
            var pizza = _pizzaRepository.GetPizzaById(id);

            if (pizza == null)
            {
                return NotFound();
            }
            // return the view
            return View(pizza);
        }
    }
}
