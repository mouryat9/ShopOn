using System;
using System.Collections.Generic;
using System.IO;
using Shopon.Entities;
using System.Threading.Tasks;
using  System.Web.Script.Serialization;


namespace Shopon.DataAccess
{
    public class ProductRepositoryFileImpl : IProductRepository
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
                File.WriteAllText("productdata.dat", new JavaScriptSerializer().Serialize(products));
                isAdded = true;
            }

            return isAdded;
        }

        public void AddAllProducts()
        {
            File.WriteAllText("productdata.dat", new JavaScriptSerializer().Serialize(products));
        }
        private bool CheckProductIfExists(Product product)
        {
            bool isPresent = false;
            foreach (var p in products)
            {
                if (p.ProductId == product.ProductId)
                {
                    isPresent = true;
                    break;
                }
            }
            return isPresent;
        }
       

        public List<Product> GetProducts()
        {
           
            return new JavaScriptSerializer().Deserialize<List<Product>>(File.ReadAllText("productdata.dat"));

        }
    }
}