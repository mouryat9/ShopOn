using Shopon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopon.DataAccess
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        List<Product> GetProducts();
        //bool RemoveProduct(int productid);
        //bool UpdateProduct(int productid, Product product);
    }
}
