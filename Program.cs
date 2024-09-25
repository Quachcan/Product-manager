using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace productmanager
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ProductManager productManager= new ProductManager();

            ProductManager productManager1 = new ProductManager();
            Product? product= productManager.findById(2);
            if (product != null)
            {
                Console.WriteLine(product.ProId);
                Console.WriteLine(product.ProName);
                Console.WriteLine(product.ProPrice);
            }
            /*Product[]? products = productManager.loadProduct();

            Product product = new Product(6, "Samsung Galaxy S24 Ultra", 2300);
            productManager.insertProduct(product);

            Console.ReadLine();*/
        }
    }
}