using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebStore.Context;
using WebStore.Interfaces;
using WebStore.Models;

namespace WebStore.Repositories
{
    public class ShopRepository : IRepository<Shop>
    {
        private StoreContext context;

        public ShopRepository(StoreContext context)
        {
            this.context = context;
        }

        public void Add(Shop item)
        {
            context.Shops.Add(item);
            context.SaveChanges();
        }
        
        public void DeleteConfirmed(int id)
        {
            Shop shop = context.Shops.Find(id);
            context.Shops.Remove(shop);
            context.SaveChanges();
        }

        public Shop Find(int? id)
        {
            Shop shop = context.Shops.Find(id);
            return shop;
        }
        public void Update(Shop item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public IEnumerable<Shop> ToList()
        {
            return context.Shops.ToList();
        }
    }
}