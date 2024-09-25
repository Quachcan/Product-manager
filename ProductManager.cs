using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace productmanager
{
    public class ProductManager
    {
        Product[]? products;
        private string sourceFilePath = @"/Applications/Document/Learning Unity/productmanager/Product.json";

        public ProductManager()
        {
            products = new Product[10];
            {
                new Product(1, "Iphone",100);
                new Product(2, "Samsung",200);
                new Product(3, "OPPO", 250);
                new Product(4, "SONY",300);
            };
        }
        public Product[]? loadProduct()
        {
            var jsonData = File.ReadAllText(sourceFilePath);
            products = JsonSerializer.Deserialize<Product[]> (jsonData);
            if (products != null)
            return products;
            return null;
        }

        public void insertProduct(Product product)
        {
            products = loadProduct();
            if (products != null)
            {
                if(product !=null)
                {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
                }
            }
            var jsonData = JsonSerializer.Serialize(products);
            File.WriteAllText(sourceFilePath, jsonData);
        }
        public Product? findById(int id)
        {
            products = loadProduct();
            if (products != null)
            {
                foreach(Product product in products)
                    {
                        if (product.ProId == id)
                        return product;
                    }
            }
            return null;
        }
        
    }
}