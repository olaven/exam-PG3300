using System.Collections.Generic;
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
        public void ShouldRetrieveNameFromConstructor()
        {
            Person person = new Salesman("Petter");
            
            Assert.That(person.Name, Is.EqualTo("Petter"));
        }

        [Test]
        public void PersonShouldHaveMoneyInWallet()
        {
            Person person = new Salesman("Kjell");
            Assert.True(person.Wallet >= 100);
        }

        [Test]
        public void PersonShouldLoseMoney()
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
        public void SalesmanShouldGetMoney() {
            Salesman salesman = new Salesman("Tor");
            Customer customer = new Customer("Hans");

            salesman.Wallet.Balance = 1000;
            var previousAmount = salesman.Wallet.Balance;
            salesman.GetItems().Add(ItemFactory.GetRandomItem(salesman, 1));
            salesman.SellItem();
            Thread.Sleep(300);

            Assert.That(previousAmount, Is.LessThan(salesman.Wallet.Balance));
        }

        [Test]
        public void EveryImageShouldHaveSameReference()
        {
            var people = new List<Person>
            {
                new Customer("Customer 1"),
                new Salesman("Salesman 1"),
                new Customer("Customer 2")
            };

            for (var i = 1; i < people.Count; i++)
            {
                Assert.That(people[i].Image, Is.EqualTo(people[i - 1].Image));
            }
        }
    }
}