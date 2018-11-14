using FleaMarket;
using Item;
using NUnit.Framework;

namespace MarketTest
{
    [TestFixture]
    public class DecoratorTest
    {
        [Test]
        public void shouldGiveDamaged()
        {
            IItem item = new ConcreteItem("item name", 100, new Customer("customer name"));
            item = new NoDamageItemDecorator(item);
            
            Assert.That(item.getDamage(), Is.EqualTo("no damage"));
        }
    }
}