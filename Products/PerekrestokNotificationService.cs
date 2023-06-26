using System;

namespace Products
{
    public class PerekrestokNotificationService : INotificationService
    {
        public void NotifyProductAdded(Product product)
        {
            Console.WriteLine($"Added new product: {product}");
        }
    }
}