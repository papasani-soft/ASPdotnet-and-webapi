using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class ProductsData
    {
        public IEnumerable<Product> ProductList
        {
            get
            {
                List<Product> products = new List<Product>()
                {
                    new Product{ ProductId=1,Name="Samsung TV",Price=4500},
                    new Product{ ProductId=2,Name="NIke TV",Price=50000}
                };
                return products;
            }
        }
    }
}