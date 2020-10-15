using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Products.Repository.RepoModels;

namespace Products.Repository
{
    public interface IProductsRepository
    {
        DbSet<Product> GetAllProducts();
    }
}
