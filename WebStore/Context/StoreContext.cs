using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using WebStore.Context.ModelConfigurations;
using WebStore.Models;

namespace WebStore.Context
{
    [DbConfigurationType(typeof(StoreContextConfiguration))]
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreDB")
        {

        }
        public IDbSet<Product> Products { get; set; }

        public IDbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        public class StoreContextConfiguration : DbConfiguration
        {
            public StoreContextConfiguration()
            {
                this.SetDefaultConnectionFactory(new LocalDbConnectionFactory("mssqllocaldb"));
                this.SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
            }
        }
    }
}