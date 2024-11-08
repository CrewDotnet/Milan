namespace Cafeteria
{
    public class LargeCoffee : Coffee, ICoffeePrice
    {
        public LargeCoffee()
        {
            
        }
        public LargeCoffee(string coffeeName)
        {
            CoffeeName = coffeeName;
        }

        public decimal PriceCalculation()
        {
            return BasePrice * 1.2m;
        }

        public string DisplayPrice()
        {
            var currencyFormat = PriceCalculation().ToString("c");
            return String.Format(currencyFormat);
        }
    }
}
