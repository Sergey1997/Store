using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebStore.Models
{
    public class Shop : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = " {0: HH.mm} ")]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = " {0: HH.mm} ")]
        public DateTime EndTime { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Shop()
        {
            Products = new List<Product>();
        }
    }
}