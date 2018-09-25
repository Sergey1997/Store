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
                Name = "�����",
                Description = "1�� - 2�"
            };
            Product p2 = new Product()
            {
                Id = 2,
                Name = "������",
                Description = "������ ������."
            };
            Product p3 = new Product()
            {
                Id = 3,
                Name = "����",
                Description = "��������������, ����������� ��������."
            };

            Shop s1 = new Shop()
            {
                Id = 1,
                Name = "���",
                Address = "�����, ��. �������, 13",
                StartTime = new DateTime(2018, 9, 22, 7, 0, 0),
                EndTime = new DateTime(2018, 9, 22, 21, 0, 0),
                Products = new List<Product>() { p1, p2 }
            };

            Shop s2 = new Shop()
            {
                Id = 2,
                Name = "�������",
                Address = "�����, ��. ���������, 24",
                StartTime = new DateTime(2018, 9, 22, 0, 0, 0),
                EndTime = new DateTime(2018, 9, 22, 12, 0, 0),
                Products = new List<Product>() { p1, p3 }
            };

            Shop s3 = new Shop()
            {
                Id = 3,
                Name = "�����������",
                Address = "�����, ��. ���������, 22",
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
