using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBanDoAnNhanh.Models
{
    public partial class PosFastFood : DbContext
    {
        public PosFastFood()
            : base("name=PosFastFood")
        {
        }

        public virtual DbSet<Admintrator> Admintrators { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<TypeProduct> TypeProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admintrator>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Orders)
                .Map(m => m.ToTable("OrderDetail").MapLeftKey("IdOrder").MapRightKey("IdProduct"));

            modelBuilder.Entity<Product>()
                .Property(e => e.NameProduct)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.PriceProduct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Decriptions)
                .IsUnicode(false);

            modelBuilder.Entity<TypeProduct>()
                .Property(e => e.NameType)
                .IsUnicode(false);

            modelBuilder.Entity<TypeProduct>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.TypeProduct)
                .WillCascadeOnDelete(false);
        }
    }
}
