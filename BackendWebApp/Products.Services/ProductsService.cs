using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Products.Repository;
using Products.Repository.RepoModels;
using Products.Services.ServiceModels.ResponseModels;

namespace Products.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public IEnumerable<ProductResponse> GetAllProducts()
        {
            var products = _productsRepository.GetAllProducts();
            List<ProductResponse> productsList = null;
            if (products != null)
            {
                productsList = new List<ProductResponse>();
                foreach (var prd in products)
                {
                    productsList.Add(
                        new ProductResponse { Description = prd.Description, Id = prd.Id, Name = prd.Name });
                }
            }

            return productsList;
        }
    }
}
