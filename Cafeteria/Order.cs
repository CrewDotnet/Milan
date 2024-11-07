using System.Xml.Linq;

namespace Cafeteria
{
    public class Order : Menu
    {
        public string LastOrderMessage { get; set; }

        public void DisplayOrderMessage (int coffeeNumber, int cupNumber)
        {
            if (cupNumber == 1 && coffeeNumber > 0 && coffeeNumber <= ListOfCoffees.Count)
            {
                var regularCoffee = new RegularCoffee(ListOfCupSizes[cupNumber - 1] + " " + ListOfCoffees[coffeeNumber - 1]);
                LastOrderMessage = $"You ordered {regularCoffee.Name} coffee and it costs {regularCoffee.DisplayPrice()}";
                Console.WriteLine(LastOrderMessage);
            }
            else if (cupNumber == 2 && coffeeNumber > 0 && coffeeNumber <= ListOfCoffees.Count)
            {
                var largeCoffee = new LargeCoffee(ListOfCupSizes[cupNumber - 1] + " " + ListOfCoffees[coffeeNumber - 1]);
                LastOrderMessage = $"You ordered {largeCoffee.Name} coffee and it costs {largeCoffee.DisplayPrice()}";
                Console.WriteLine(LastOrderMessage);
            }
            else
            {
                LastOrderMessage = "You chose wrong option(s), try again!";
                Console.WriteLine(LastOrderMessage);
            } 
        }
    }
}
