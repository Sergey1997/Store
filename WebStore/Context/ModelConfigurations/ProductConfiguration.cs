using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebStore.Models;

namespace WebStore.Context.ModelConfigurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("products");
            HasKey(p => p.Id);

            Property(property => property.Id).HasColumnName("id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); ;
            Property(property => property.Name).HasColumnName("name").IsRequired();
            Property(property => property.Description).HasColumnName("description").IsOptional();
        }
    }
}