using FleaMarket;
using Item;
using NUnit.Framework;

namespace MarketTest
{
    [TestFixture]
    public class DecoratorTest
    {
        private IItem _item; 

        [SetUp]
        public void init()
        {
            _item = new ConcreteItem("item name", 100, new Customer("customer name"));
        }
       
        [Test]
        public void shouldGiveNoDamage()
        {
            _item = new NoDamageItemDecorator(_item);
            
            Assert.That(_item.getDamage(), Is.EqualTo("no damage"));
        }

        [Test]
        public void shouldGiveDecentCondition()
        {
            _item = new DecentConditionItemDecorator(_item);
            
            Assert.That(_item.getDamage(), Is.EqualTo("decent damage"));
        }

        [Test]
        public void shouldGivePerfectCondition()
        {
            _item = new PerfectConditionItemDecorator(_item);
            
            Assert.That(_item.getCondition(), Is.EqualTo("perfect condition"));
        }

        [Test]
        public void priceCantBeLessThan0()
        {
            IItem item = new ConcreteItem("Thomas", -100, new Customer("customer name"));
            Assert.That(item.getPrice(), Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void priceAdjustedDownOnDTerribleCondition()
        {
            _item = new TerribleConditionItemDecorator(_item);
            
            Assert.That(_item.getPrice() < 100, Is.True);
            
        }
    }
}