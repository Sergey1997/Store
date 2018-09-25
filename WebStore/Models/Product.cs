using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
        public Product()
        {
            Shops = new List<Shop>();
        }
    }
}