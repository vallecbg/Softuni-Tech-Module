namespace ShoppingList.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int Id { get; set; }

        public int Priority { get; set; }
        
        public string Name { get; set; }

        public int Quantity { get; set; }
        
        public string Status { get; set; }

    }
}
