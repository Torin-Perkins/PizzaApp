using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzaApp.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Meat Pizzas", "Pizzas with meat" },
                    { 2, "Veggie Pizzas", "Pizzas with veggies" },
                    { 3, "Vegetarian Pizzas", "Pizzas with no meat" }
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "PizzaId", "AllergyInformation", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPizzaOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription", "categoryId" },
                values: new object[,]
                {
                    { 1, "Contains Gluten, Eggs, Milk", "https://i.ibb.co/27J06fLd/Pop-Pizza-3-56.jpg", "https://i.ibb.co/27J06fLd/Pop-Pizza-3-56.jpg", true, true, "Large pepperoni pizza with american cheese comes with any dipping sauce", "Pepperoni Pizza", 9.25m, "Plain Old Pepperoni Pizza", 1 },
                    { 2, "Contains Gluten, Eggs, Milk", "https://i.ibb.co/21s1vfny/classic-cheese-pizza-FT-RECIPE0422-31a2c938fc2546c9a07b7011658cfd05.jpg", "https://i.ibb.co/21s1vfny/classic-cheese-pizza-FT-RECIPE0422-31a2c938fc2546c9a07b7011658cfd05.jpg", true, true, "Large Cheese Pizza with american cheese, great for any occasion", "Cheese Pizza", 8.00m, "Plain Old Cheese Pizza", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
