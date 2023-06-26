using Products;

namespace ProgramHWThreads

    {
        class ProgramHWThreads
        {static void Main(string[] args)
            {
                var baskets = new ProductCard[10];

                for (int i = 0; i < baskets.Length; i++)
                {
                    baskets[i] = new ProductCard(new List<Product>());
                    // baskets[i].ProductAddedEvent += HandleProductAddedEvent;
                    // baskets[i].BuyEvent += HandleBuyEvent;
                    baskets[i].AddProducts(
                        new Product(10, "Milk"),
                        new Product(20, "Sugar"),
                        new Product(30, "Honey")
                    );
                }

                int totalSum = 0;
                Parallel.ForEach(baskets, basket =>
                {
                    int basketSum = basket.GetTotalSumm();
                    Interlocked.Add(ref totalSum, basketSum);
                });

                Console.WriteLine("Total sum of all products: " + totalSum);
                Console.ReadLine();
            }

            // private static void HandleProductAddedEvent(object sender, ProductAddEventArgs e)
            // {
            //     Console.WriteLine("Product added: " + e.AddedProduct);
            // }
            //
            // private static void HandleBuyEvent(object sender, decimal total)
            // {
            //     Console.WriteLine("Buy event triggered. Total: " + total);
            // }
        }
    }

