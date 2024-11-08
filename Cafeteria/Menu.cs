namespace Cafeteria
{
    public class Menu
    {
        public List<string> ListOfCoffees { get; set; } = new List<string>() { "Espresso", "Latte Macchiato", "Cappuccino" };
        public List<string> ListOfCupSizes { get; set; } = new List<string>() { "Regular", "Large" };

        public int SelectCoffee()
        {
            Console.WriteLine("Welcome to the Coffee Shop!\nChoose coffe:");

            int coffeeIndex = 0;
            foreach (var coffe in ListOfCoffees)
            {
                Console.WriteLine(coffeeIndex + 1 + ". " + coffe);
                coffeeIndex++;
            }

            Console.Write("Enter number: ");

            try
            {
                return Convert.ToInt32(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Format you entered is wrong!");
                return 0;
            }
}

        public int SelectCupSize()
        {
            Console.WriteLine("\nNow choose cup size: ");

            int cupIndex = 0;
            foreach (var cupSize in ListOfCupSizes)
            {
                Console.WriteLine(cupIndex + 1 + ". " + cupSize);
                cupIndex++;
            }

            Console.Write("Enter number: ");

            try
            {
                return Convert.ToInt32(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Format you entered is wrong!");
                return 0;
            }
        }

        public string GetCoffeNameFromInput (int selectedCoffee, int selectedCupSize)
        {
            return ListOfCupSizes[selectedCupSize - 1] + " " + ListOfCoffees[selectedCoffee - 1];
        }
    }
}
