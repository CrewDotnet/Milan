using Cafeteria;

var menu = new Menu();
var order = new Order();

int selectedCoffeeOption = menu.SelectCoffee();
int selectedCupOption = menu.SelectCupSize();

order.DisplayOrderMessage(selectedCoffeeOption, selectedCupOption);
