using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.UnitTests
{
    [TestFixture]
    public class LargeCoffeeTests
    {
        [Test]
        public void PriceCalculation_WhenCalled_ReturnsCorrectPrice()
        {
            var largeCoffee = new LargeCoffee();

            var result = largeCoffee.PriceCalculation();

            Assert.That(result, Is.EqualTo(2.4));
        }
    }
}
