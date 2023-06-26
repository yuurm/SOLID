using System;

namespace Products
{
    public class MagnitNotificationService : INotificationService
    {
        public void NotifyProductAdded(Product product)
        {
            Console.WriteLine($"MAGNIT! Added new product: {product}");
        }
    }
}