using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Products.Repository.RepoModels;

namespace Products.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductsDbContext _context;

        public ProductsRepository(ProductsDbContext context)
        {
            _context = context;
        }
        public DbSet<Product> GetAllProducts()
        {
            return _context.Product;
        }
    }
}
