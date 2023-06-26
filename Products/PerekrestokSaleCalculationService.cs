namespace Products
{
    public class PerekrestokSaleCalculationService : ISaleCalculationService
    {
        public decimal CalculateSale(decimal totalSum)
        {
            return 0.9M;
        }
    }
}