namespace Cafeteria
{
    public abstract class Coffee
    {
        public string Name { get; set; }
        public decimal BasePrice { get; } = 2;

        public abstract string DisplayPrice();
    }
}
