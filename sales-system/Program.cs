using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "T-shirt";
            product1.Price = 15;

            Product product2 = new Product();
            product2.Name = "Pants";
            product2.Price = 40;

            Product product3 = new Product();
            product3.Name = "Shoes";
            product3.Price = 100;

            Saller saller1 = new Saller();
            saller1.Name = "José";
            saller1.Age = 30;
            saller1.Product = product1;

            Saller saller2 = new Saller();
            saller2.Name = "Juan";
            saller2.Age = 20;
            saller2.Product = product2;

            Saller saller3 = new Saller();
            saller3.Name = "María";
            saller3.Age = 25;
            saller3.Product = product3;

            float TottalAmound = saller1.Product.Price + saller2.Product.Price + saller3.Product.Price;

            Sales totalSales1 = new Sales();
            totalSales1.Saller = saller1;
            totalSales1.Comment = "Sales Tottal Amound: ";

            Console.WriteLine(totalSales1.Comment + TottalAmound);
        }
    }
}
