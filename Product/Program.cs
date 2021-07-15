using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Dönüşüm";
            product1.NumberOfPages = "120";
            product1.Price = 10;

            Product product2 = new Product();
            product2.ProductName = "Çölde Kutup Ayısı";
            product2.NumberOfPages = "175";
            product2.Price = 13.75;


            Product product3 = new Product();
            product3.ProductName = "1984";
            product3.NumberOfPages = "320";
            product3.Price = 16;

           
            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine("Product Name: "+product.ProductName + "  " + "Number of Pages: "+product.NumberOfPages+ "  "+ "Price: "+product.Price+": ");
            }

        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public string NumberOfPages { get; set; }
        public double Price { get; set; }
    }
}
