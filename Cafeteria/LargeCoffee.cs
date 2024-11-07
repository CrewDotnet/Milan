namespace Cafeteria
{
    class LargeCoffee : Coffee, IPriceCalculation  //public
    {
        public LargeCoffee(string name)
        {
            Name = name;
        }

        public decimal PriceCalculation()
        {
            return BasePrice * 1.2m;
        }

        public override string DisplayPrice()
        {
            var currencyFormat = PriceCalculation().ToString("c");
            return String.Format(currencyFormat);
        }
    }
}
