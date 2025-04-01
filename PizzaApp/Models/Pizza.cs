namespace PizzaApp.Models
{
    public class Pizza
    {
        /*
         * PizzaId: int
         * Name: string
         * ShortDescription: string
         * LongDescriptiuon: string
         * Price: decimal
         * AllergyInformation: string
         * ImageUrl: string
         * ImageThumbnailUrl: string
         * IsPizzaOfTheWeek: bool
         * InStock: bool
         * CategoryId: int
         * Category: Category
         */

        public int PizzaId { get; set; } //important
        public string Name { get; set; } //important
        public string ShortDescription { get; set; } // one of the descriptions
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price {  get; set; } // important
        public string ImageUrl { get; set; } // important
        public string ImageThumbnailUrl { get; set; } //important

        public bool IsPizzaOfTheWeek { get; set; }
        public bool InStock {  get; set; }
        public int categoryId {  get; set; } // important
        public Category category {  get; set; } // important

    }
}
