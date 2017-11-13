using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using P03_SalesDatabase.Data;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext()
        {

        }

        public SalesContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Tags> Tags { get; set; }

        public DbSet<Dogs> Dogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(n => n.Name)
                .HasMaxLength(100)
                .IsUnicode();

                entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.Property(p => p.Name).IsRequired().HasMaxLength(50).IsUnicode();
                entity.Property(p => p.Quantity).IsRequired();
                entity.Property(p => p.Price).IsRequired();
                entity.Property(p => p.Description).IsRequired().HasMaxLength(250).HasDefaultValue("No description");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.Property(n => n.Name)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode();

            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(s => s.Date).IsRequired().HasDefaultValueSql("GETDATE()");
            });

            modelBuilder.Entity<Tags>(entity =>
            entity.HasKey(e => e.TagId));

            modelBuilder.Entity<Dogs>(entity =>
           entity.HasKey(e => e.DogId));

            modelBuilder.Entity<Product>()
               .HasMany(p => p.Sales)
               .WithOne(s => s.Product)
               .HasForeignKey(s => s.ProductId);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Sales)
                .WithOne(s => s.Customer)
                .HasForeignKey(s => s.CustomerId);

            modelBuilder.Entity<Store>()
                .HasMany(st => st.Sales)
                .WithOne(sale => sale.Store)
                .HasForeignKey(sale => sale.StoreId);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Product)
                .WithMany(p => p.Sales)
                .HasForeignKey(s => s.ProductId);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CustomerId);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Store)
                .WithMany(st => st.Sales)
                .HasForeignKey(sale => sale.StoreId);
        }


    }
}
