using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopon.Entities;

namespace Shopon.DataAccess
{
    public class ProductRepositoryListImpl : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public bool AddProduct(Product product)
        {
            bool isAdded = false;
            if (CheckProductIfExists(product))
            {

            }
            else
            {
                products.Add(product);
                isAdded = true;
            }
            
            return isAdded;
        }

        private bool CheckProductIfExists(Product product)
        {
            bool isPresent = false;
            foreach (var p in products)
            {
                if(p.ProductId == product.ProductId)
                {
                    isPresent = true;
                    break;
                }
            }
            return isPresent;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
