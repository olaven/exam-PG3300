using NUnit.Framework;
using People;

namespace MarketTest
{
    [TestFixture]
    public class PersonFactoryTest
    {
        [Test]
        public void ShouldManufactureCustomer()
        {
            var person = PersonFactory.GetPerson(PersonType.Customer); 
            
            Assert.IsInstanceOf(typeof(Customer), person);
        }
        
        [Test]
        public void ShouldManufactureSalesman()
        {
            var person = PersonFactory.GetPerson(PersonType.Salesman); 
            
            Assert.IsInstanceOf(typeof(Salesman), person);
        }
    }
}