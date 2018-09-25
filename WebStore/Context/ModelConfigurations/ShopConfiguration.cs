using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebStore.Models;

namespace WebStore.Context.ModelConfigurations
{
    public class ShopConfiguration : EntityTypeConfiguration<Shop>
    {
        public ShopConfiguration(DbModelBuilder modelBuilder)
        {
            ToTable("shops");
            HasKey(p => p.Id);
            modelBuilder.Entity<Shop>().HasMany(c => c.Products)
                        .WithMany(s => s.Shops)
                        .Map(t => t.MapLeftKey("shopId")
                        .MapRightKey("productId")
                        .ToTable("ShopProduct"));

            Property(property => property.Id).HasColumnName("id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); ;
            Property(property => property.Name).HasColumnName("name").IsRequired();
            Property(property => property.Address).HasColumnName("address").IsRequired();
            Property(property => property.StartTime).HasColumnName("start_time").IsOptional();
            Property(property => property.EndTime).HasColumnName("end_time").IsOptional();
        }
    }
}