namespace Cafeteria
{
    class RegularCoffee : Coffee, IPriceCalculation
    {
        public RegularCoffee(string name)
        {
            Name = name;
        }
        public decimal PriceCalculation()
        {
            return BasePrice;
        }

        public override string DisplayPrice()
        {
            var currencyFormat = PriceCalculation().ToString("c");
            return String.Format(currencyFormat);
        }
    }
}
