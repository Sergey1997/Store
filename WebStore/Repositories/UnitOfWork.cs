using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStore.Context;

namespace WebStore.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private StoreContext context = new StoreContext();
        private ShopRepository shopRepository;
        private ProductRepository productRepository;

        public ShopRepository Shops
        {
            get
            {
                if (shopRepository == null)
                    shopRepository = new ShopRepository(context);
                return shopRepository;
            }
        }
        public ProductRepository Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(context);
                return productRepository;
            }
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}