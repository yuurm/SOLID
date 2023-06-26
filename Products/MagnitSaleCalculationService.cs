namespace Products
{
    public class MagnitSaleCalculationService : ISaleCalculationService
    {
        public decimal CalculateSale(decimal totalSum)
        {
            decimal sale = 1;
            if (totalSum > 1000)
            {
                sale = 0.95M;
            }
            else if (totalSum > 100)
            {
                sale = 0.975M;
            }
            else if (totalSum > 25)
            {
                sale = 0.99M;
            }
            return sale;
        }
    }

    

}