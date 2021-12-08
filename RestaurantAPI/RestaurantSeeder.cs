using RestaurantAPI.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantAPI
{
    public class RestaurantSeeder
    {

        private readonly RestaurantDbContext _dbContext;

        public RestaurantSeeder(RestaurantDbContext dbContext)
        {

            _dbContext = dbContext;

        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {

                if (!_dbContext.Restaurants.Any())
                {

                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();

                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {

                new Restaurant()
                {

                    Name = "Pizzeria",
                    Category = "Pizza",
                    Description = "Pyszna",
                    ContactEmail = "pizzeria@pizza.pl",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {

                            Name = "Hawajska",
                            Price = 400.00M,
                            Description = "mniami"

                        },

                        new Dish()
                        {

                            Name = "Jalapenio",
                            Price = 20.00M,
                            Description = "mniami"

                        },
                    },

                    Address = new Address()
                    {

                        City = "Morag",
                        Street = "Baltycka 21",
                        PostalCode = "10-144"

                    }
                },

                new Restaurant()
                {

                    Name = "Sushi Bar",
                    Category = "Sushi",
                    Description = "Pyszne",
                    ContactEmail = "Susharnia@sushi.pl",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {

                            Name = "Sushi box 1",
                            Price = 40000.00M,
                            Description = "mniami"

                        },
                        new Dish()
                        {

                            Name = "Jalapenio sushi box",
                            Price = 2000000.00M,
                            Description = "mniami"

                        },
                    },

                    Address = new Address()
                    {

                        City = "Morag",
                        Street = "Baltycka 21",
                        PostalCode = "10-144"

                    }

                }
            };
            return restaurants;
        }
    }
}
       


