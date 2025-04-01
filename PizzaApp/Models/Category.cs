namespace PizzaApp.Models
{
    public class Category
    {
        // CategoryId
        // CategoryName
        // Description
        // List of the products (Pizzas) <>
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Pizza> Pizzas { get; set; }
    }
}
