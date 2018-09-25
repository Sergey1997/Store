namespace WebStore.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebStore.Context.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebStore.Context.StoreContext context)
        {
            Product p1 = new Product()
            {
                Id = 1,
                Name = "Банан",
                Description = "1кг - 2р"
            };
            Product p2 = new Product()
            {
                Id = 2,
                Name = "Яблоко",
                Description = "Зелёное яблоко."
            };
            Product p3 = new Product()
            {
                Id = 3,
                Name = "Хлеб",
                Description = "Необыкновенный, деревенский хлебушек."
            };

            Shop s1 = new Shop()
            {
                Id = 1,
                Name = "ОМА",
                Address = "Минск, ул. Неопала, 13",
                StartTime = new DateTime(2018, 9, 22, 7, 0, 0),
                EndTime = new DateTime(2018, 9, 22, 21, 0, 0),
                Products = new List<Product>() { p1, p2 }
            };

            Shop s2 = new Shop()
            {
                Id = 2,
                Name = "Простор",
                Address = "Минск, ул. Наполеона, 24",
                StartTime = new DateTime(2018, 9, 22, 0, 0, 0),
                EndTime = new DateTime(2018, 9, 22, 12, 0, 0),
                Products = new List<Product>() { p1, p3 }
            };

            Shop s3 = new Shop()
            {
                Id = 3,
                Name = "Электросила",
                Address = "Минск, ул. Курчатова, 22",
                StartTime = new DateTime(2018, 9, 22, 8, 0, 0),
                EndTime = new DateTime(2018, 9, 22, 19, 00, 0),
                Products = new List<Product>() { p1, p2, p3 }
            };

            context.Products.AddOrUpdate(p1, p2, p3);
            context.SaveChanges();
            context.Shops.AddOrUpdate(s1, s2, s3);
            context.SaveChanges();
        }
    }
}
