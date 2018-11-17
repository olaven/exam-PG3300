using System.Threading;
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
            
            Assert.That(person.Name, Is.EqualTo("Petter"));
        }

        [Test]
        public void personShouldHaveMoneyInWallet()
        {
            Person person = new Salesman("Kjell");
            Assert.True(person.Wallet >= 100);
        }

        [Test]
        public void personShouldLoseMoney()
        {
            Salesman salesman = new Salesman("Tor");
            Customer customer = new Customer("Hans-Arne");
            
            customer.Wallet.Balance = 1000;
            var previousAmount = customer.Wallet.Balance;
            salesman.GetItems().Add(ItemFactory.GetRandomItem(salesman, 5));
            salesman.SellItem();
            Thread.Sleep(300);
            
            Assert.That(previousAmount, Is.GreaterThan(customer.Wallet.Balance));   
        }

        [Test]
        public void salesmanShouldGetMoney() {
            Salesman salesman = new Salesman("Tor");
            Customer customer = new Customer("Hans");

            salesman.Wallet.Balance = 1000;
            var previousAmount = salesman.Wallet.Balance;
            salesman.GetItems().Add(ItemFactory.GetRandomItem(salesman, 1));
            salesman.SellItem();
            Thread.Sleep(300);

            Assert.That(previousAmount, Is.LessThan(salesman.Wallet.Balance));
        }
    }
}