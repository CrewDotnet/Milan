namespace Cafeteria.UnitTests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        [TestCase (1, 1, "You ordered Regular Espresso coffee and it costs $2.00")]
        [TestCase (1, 2, "You ordered Large Espresso coffee and it costs $2.40")]
        [TestCase (4, 3, "You chose wrong option(s), try again!")]
        public void DisplayOrder_WhenCalled_ReturnCorrectOrderMessage(int coffeeNumber, int cupNumber, string expectedResult)
        {
            var order = new Order();

            order.DisplayOrderMessage(coffeeNumber, cupNumber);

            Assert.That(order.LastOrderMessage, Is.EqualTo(expectedResult));
        }
    }
}