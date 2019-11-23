using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using MyProduct.Domain.Entities;

namespace MyProduct.DataAccess.Configuration
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            this.ToTable("tblProducts");
            
            this.HasKey(t => t.ProductID);
            //MongoDB Compatible mapping with _ID column. Also set DatabaseGeneratedOption.None
            this.Property(t => t.ProductID).HasColumnName("_id");
            this.Property(t => t.ProductID).HasColumnOrder(0);
            this.Property(t => t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            

            this.Property(t => t.ProductName).HasColumnOrder(1);
            this.Property(t => t.ProductName).HasMaxLength(30);
            this.Property(t => t.ProductName).IsUnicode(false);
            this.Property(t => t.ProductName).IsRequired();

            this.Property(t => t.UnitPrice ).HasColumnOrder(2);
            this.Property(t => t.UnitPrice).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.UnitPrice).IsRequired();

            
            this.Property(t => t.CategoryID).HasColumnOrder(3);
            this.Property(t => t.CategoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.CategoryID).IsRequired();


            this.Property(t => t.SupplierID).HasColumnOrder(4);
            this.Property(t => t.SupplierID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.SupplierID).IsRequired();
        }
    }
}
