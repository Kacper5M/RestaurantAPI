using RestaurantAPI2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI2
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
            if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Restaurants.Any())
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
                    Name = "BurgerKing",
                    Category = "Fast Food",
                    Desc = "BurgerKing Description",
                    ContactEmail = "burgerking@gmail.com",
                    HasDelivery = true,

                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Whooper",
                            Price = 16,
                        },

                        new Dish()
                        {
                            Name = "Frytki",
                            Price = 8,
                        },

                    },
                    Address = new Address()
                    {
                        City = "Bydgoszcz",
                        Street = "Kopernika",
                        PostalCode = "43-433"
                    }
                },
                new Restaurant()
                {
                    Name = "KebabStrefa",
                    Category = "Fast food",
                    Desc = "KebabStrefa Description",
                    ContactEmail = "KebabStrefa@gmail.com",
                    HasDelivery = true,

                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Kebab",
                            Price = 16,
                        },

                        new Dish()
                        {
                            Name = "Rollo",
                            Price = 22,
                        },

                    },
                    Address = new Address()
                    {
                        City = "Bydgoszcz",
                        Street = "Fordonska",
                        PostalCode = "32-333"
                    }
                },
            };
            return restaurants;
        }
    }
}
