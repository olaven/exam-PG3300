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
        public void Init()
        {
            _item = new ConcreteItem(100, new Customer("customer name"));
        }
       
        [Test]
        public void ShouldGiveNoDamage()
        {
            _item = new NoDamageItemDecorator(_item);
            
            Assert.That(_item.GetDamage(), Is.EqualTo(" that has no damage"));
        }
        
        [Test]
        public void ShouldGiveMultipleDamage()
        {
            _item = new MultipleDamageItemDecorator(_item);
            Assert.That(_item.GetDamage(), Is.EqualTo(" with two huge scratches and one bump"));
        }

        [Test]
        public void ShouldGivePerfectCondition()
        {
            _item = new PerfectConditionItemDecorator(_item);
            
            Assert.That(_item.GetCondition(), Is.EqualTo(" in perfect condition"));
        }

        [Test]
        public void ShouldGiveTerribleCondition()
        {
            _item = new TerribleConditionItemDecorator(_item);
            
            Assert.That(_item.GetCondition(), Is.EqualTo(" in terrible condition"));
        }
    
        [Test]
        public void PriceCantBeLessThan0()
        {
            IItem item = new ConcreteItem(-100, new Customer("customer name"));
            Assert.That(item.GetPrice(), Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void PriceAdjustedDownOnDTerribleCondition()
        {
            _item = new TerribleConditionItemDecorator(_item);
            
            Assert.That(_item.GetPrice() < 100, Is.True);
        }
    }
}