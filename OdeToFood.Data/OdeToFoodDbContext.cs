using System;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext: DbContext
    {
        public OdeToFoodDbContext()
        {
            public DbSet<Restaurant> Restaurants { get; set; }
        }
    }
}
