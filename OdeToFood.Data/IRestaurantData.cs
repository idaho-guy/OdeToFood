﻿using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name= "Scott's Pizza", Location = "Maryland", Cusine = CuisineType.Italian},
                new Restaurant{Id = 2, Name= "Mark's Pizza", Location = "Oak Park", Cusine = CuisineType.Indian},
                new Restaurant{Id = 3, Name= "Bill's Pizza", Location = "Chicago", Cusine = CuisineType.Mexican},
                new Restaurant{Id = 4, Name= "Shouvik's Pizza", Location = "India", Cusine = CuisineType.Indian}

            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
