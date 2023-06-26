using System;

namespace Products
{
    public class DiksiNotificationService : INotificationService
    {
        public void NotifyProductAdded(Product product)
        {
            Console.WriteLine($"Welcome! Added new product: {product}");
        }
    }
}