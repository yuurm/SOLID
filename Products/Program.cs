using System;
using System.IO;


namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
           

        }


        

        
        
        static void Main1()
        {
            var pr1 = new Product(10000, "pr1");
            var pr2 = new Product(99, "pr2");
            var pr3 = new Product(10, "pr3");

            // var card = new ProductCard(NotifyMagnit, NotifyOfSaleByConsole, CalculateSaleMagnit, obj => true);
            //
            // card.BuyEvent += CardOnBuyEvent;
            // card.AddProducts(new []{pr1, pr2, pr3});
            // card.Buy();
            //
            // card.BuyEvent -= CardOnBuyEvent;

            
        }

        private static void CardOnBuyEvent(object sender, decimal total)
        {
            Console.WriteLine($"Сделана покупка на сумму {total}");
        }

        public static void NotifyPerekrestok(Product product)
        {
            Console.WriteLine($"Added new product: {product}");
        }
        
        public static void NotifyDiksi(Product product)
        {
            Console.WriteLine($"Welcome! Added new product: {product}");
        }
        
        public static void NotifyMagnit(Product product)
        {
            //Console.WriteLine($"MAGNIT! Added new product: {product}");
        }

        public static void NotifyOfSaleByConsole(decimal sale, decimal summOfSale)
        {
           // Console.WriteLine($"Скидка составила {sale:P} процентов. В деньгах: {summOfSale:N0}");
        }
        
        public static void NotifyOfSaleByFile(decimal sale, decimal summOfSale)
        {
            var message = $"Скидка составила {sale:P} процентов. В деньгах: {summOfSale:N0}";
            File.WriteAllText("log.txt", message);
        }
        
        // private readonly Func<decimal, decimal> _calculateSaleFunc;

        public static decimal CalculateSaleMagnit(decimal summ)
        {
            decimal sale = 1;
            
            if (summ > 1000)
            {
                sale = 0.95M;
            }
            else if (summ > 100)
            {
                sale = 0.975M;
            }
            else if (summ > 25)
            {
                sale =  0.99M;
            }
        
            return sale;
        }
        
        public static decimal CalculateSalePerekrestok(decimal summ)
        {
            decimal sale = 0.9M;
        
            return sale;
        }
    }
}