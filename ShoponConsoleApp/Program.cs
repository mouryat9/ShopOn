using Shopon.Business;
using Shopon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoponConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            ProductManager manager = new ProductManager();                        
            while (true)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("----");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:                        
                        AddProduct(manager); break;
                    case 2: DisplayProduct(manager); break;
                    case 3: System.Environment.Exit(0); break;
                }
            }
        }

        private static void DisplayProduct(ProductManager manager)
        {
            List<Product> products = manager.GetAllProducts();
            Console.WriteLine("Product Details");
            Console.WriteLine("Pid\tName\t\t Price");
            Console.WriteLine("---------------------------------------");
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductId + "\t" +
                product.ProductName + "\t\t" + product.Price);
            }
            
        }

        private static void AddProduct(ProductManager manager)
        {
            Product product = new Product();
            Console.WriteLine("Enter product Id: ");
            product.ProductId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter product name :" );
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Enter product price :");
            product.Price = Convert.ToDouble(Console.ReadLine());
            if (manager.InsertProduct(product))
            {
                Console.WriteLine("Record inserted.");
            } else
            {
                Console.WriteLine("There was problem inserting record.");
            }
        }
    }
}
