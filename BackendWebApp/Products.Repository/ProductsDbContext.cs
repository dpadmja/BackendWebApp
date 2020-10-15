using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Products.Repository.RepoModels;

//using Products.Repository.RepoModels;

namespace Products.Repository
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> dbOptions) : base(dbOptions)
        {

        }

        public ProductsDbContext()
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}
