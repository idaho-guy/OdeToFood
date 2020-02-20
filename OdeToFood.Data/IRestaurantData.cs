using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name= "Scott's Pizza", Location = "Maryland", Cusine = CuisineType.Italian},
                new Restaurant{Id = 2, Name= "ScMark's Pizza", Location = "Oak Park", Cusine = CuisineType.Indian},
                new Restaurant{Id = 3, Name= "Bill's Pizza", Location = "Chicago", Cusine = CuisineType.Mexican},
                new Restaurant{Id = 4, Name= "Shouvik's Pizza", Location = "India", Cusine = CuisineType.Indian}

            };

        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name) 
                   orderby r.Name
                   select r;
        }
    }
}
