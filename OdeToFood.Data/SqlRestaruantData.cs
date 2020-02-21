using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;
namespace OdeToFood.Data
{
    public class SqlRestaruantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaruantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            db.Add(restaurant);
            return restaurant;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Restaurant Delete(int id)
        {
            var rest = GetById(id);
            if(rest != null)
            {
                db.Restaurants.Remove(rest);
            }
            return rest;
        }

        public Restaurant GetById(int id)
        {
            return db.Restaurants.Find(id);
        }

        public int GetCountOfRestaurants()
        {
            return db.Restaurants.Count();
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            var query = from r in db.Restaurants
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query.ToArray();
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var entity = db.Restaurants.Attach(updatedRestaurant);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return updatedRestaurant;
        }
    }
}
