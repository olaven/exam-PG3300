using FleaMarket;
using Item;
using NUnit.Framework;

namespace MarketTest
{
    [TestFixture]
    public class PersonTest
    {
        [Test]
        public void shouldRetrieveNameFromConstructor()
        {
            Person person = new Salesman("Petter");
            
            Assert.That(person.GetName(), Is.EqualTo("Petter"));
        }
    }
}