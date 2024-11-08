using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.UnitTests
{
    [TestFixture]
    public class RegularCoffeeTests
    {
        [Test]
        public void PriceCalculation_WhenCalled_ReturnsCorrectPrice()
        {
            var regularCoffee = new RegularCoffee();

            var result = regularCoffee.PriceCalculation();

            Assert.That(result, Is.EqualTo(2));
        }
    }
}
