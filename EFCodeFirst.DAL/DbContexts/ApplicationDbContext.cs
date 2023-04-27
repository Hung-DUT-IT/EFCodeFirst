using EFCodeFirst.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirst.DAL.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            
        }
    }
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { IdCateogory = 1, NameCategory = "Phone" });


            modelBuilder.Entity<Product>().HasData (
                new Product { IdProduct = 1, NameProduct = "IPhone", Price = 999, IdCategory = 1 },
                new Product { IdProduct = 2, NameProduct = "Mac", Price = 999, IdCategory = 1 },
                new Product { IdProduct = 3, NameProduct = "IPac", Price = 999, IdCategory = 1 },
                new Product { IdProduct = 4, NameProduct = "I", Price = 999, IdCategory = 1 }
                );
        }
    }
}
