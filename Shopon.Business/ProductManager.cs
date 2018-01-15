using Shopon.DataAccess;
using Shopon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopon.Business
{
    public class ProductManager
    {
        private IProductRepository productRepo =
            new ProductRepositoryFileImpl();

        public bool InsertProduct(Product product)
        {
            return productRepo.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return productRepo.GetProducts();
        }

    }
}
