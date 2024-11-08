namespace Cafeteria
{
    public class RegularCoffee : Coffee, ICoffeePrice
    {
        public RegularCoffee()
        {
            
        }
        public RegularCoffee(string coffeeName)
        {
            CoffeeName = coffeeName;
        }
        public decimal PriceCalculation()
        {
            return BasePrice;
        }

        public string DisplayPrice()
        {
            var currencyFormat = PriceCalculation().ToString("c");
            return String.Format(currencyFormat);
        }
    }
}
