using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using WebStore.Context;
using WebStore.Interfaces;
using WebStore.Models;

namespace WebStore.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private StoreContext context;

        public ProductRepository(StoreContext context)
        {
            this.context = context;
        }
        public void Add(Product item)
        {
            context.Products.Add(item);
            context.SaveChanges();
        }
        
        public void DeleteConfirmed(int id)
        {
            Product product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public Product Find(int? id)
        {
            Product product = context.Products.Find(id);
            return product;
        }

        public void Update(Product item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public IEnumerable<Product> ToList()
        {
            return context.Products.ToList();
        }
    }
}