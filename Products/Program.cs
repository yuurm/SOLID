using System;
using System.Collections.Generic;
using System.IO;


namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr1 = new Product(10000, "pr1");
            var pr2 = new Product(99, "pr2");
            var pr3 = new Product(10, "pr3");

            var magnitNotificationService = new MagnitNotificationService();
            var magnitSaleCalculationService = new MagnitSaleCalculationService();

            var card = new ProductCard(new List<Product>(), magnitNotificationService, magnitSaleCalculationService);

            card.AddProducts(new[] { pr1, pr2, pr3 });
            card.Buy();
        }

    }
}