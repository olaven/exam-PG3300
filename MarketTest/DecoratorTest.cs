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
        public void priceCannotBeZero()
        {
            PriceAdjuster adjuster = new PriceAdjuster();
            adjuster.adjustPriceOf(_item, -100, -11); // has to be negative price if something is wrong
            
            Assert.That(_item, Is.EqualTo(_item.Price));
        }

        [Test]
        public void priceAdjustedDownOnDTerribleCondition()
        {
            _item = new TerribleConditionItemDecorator(_item);
            
            Assert.That(_item.Price < 100, Is.True);
            
        }
    }
}