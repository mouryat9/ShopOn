using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopon.Entities
{
    [Serializable]
    public class Product
    {
        public Product()
        {
            
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        //public Company Company { get; set; }
    }
}
