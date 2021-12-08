using RestaurantAPI.Entities;

namespace RestaurantAPI.Models
{
    public class DishDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int RestaurantId { get; set; }
    }
}
