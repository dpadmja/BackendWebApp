using System;
using System.Collections.Generic;
using Products.Services.ServiceModels.ResponseModels;

namespace Products.Services
{
    public interface IProductsService
    {
        IEnumerable<ProductResponse> GetAllProducts();
    }
}
