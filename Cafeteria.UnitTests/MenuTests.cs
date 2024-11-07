namespace Cafeteria.UnitTests
{
    [TestFixture]
    public class MenuTests
    {
        private Menu _menu;

        [SetUp]
        public void SetUp()
        {
            _menu = new Menu();
        }

        [Test]
        public void SelectCoffee_WhenTheUserGivesInputNumber_ReturnsInputNumber()
        {
            Console.SetIn(new StringReader("1"));
            
            var result = _menu.SelectCoffee();
            
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test]
        public void SelectCoffee_WhenTheUserGivesInvalidInput_ReturnsError()
        {
            Console.SetIn(new StringReader("n"));
            
            var result = _menu.SelectCoffee();
            
            Assert.That(result, Is.EqualTo(0));
        }
        
        [Test]
        public void SelectCupSize_WhenTheUserGivesInputNumber_ReturnsInputNumber()
        {
            Console.SetIn(new StringReader("2"));

            var result = _menu.SelectCupSize();

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void SelectCupSize_WhenTheUserGivesInvalidInput_ReturnsError()
        {
            Console.SetIn(new StringReader("@"));

            var result = _menu.SelectCupSize();

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
