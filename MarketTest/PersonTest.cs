using System.Collections.Generic;
using System;
using System.Collections;
using System.Threading;
using FleaMarket;
using Item;
using NUnit.Framework;
using People;

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
        public void SalesmanShouldGetMoney() {
            Salesman salesman = new Salesman("Tor");
            Customer customer = new Customer("Hans");

            salesman.Wallet.Balance = 1000;
            var previousAmount = salesman.Wallet.Balance;
            salesman.GetItems().Add(ItemFactory.GetRandomItem(salesman));
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

        public void ShouldBeThreadSafe()
        {
            ArrayList customers = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                customers.Add(PersonFactory.GetPerson(PersonType.Customer));
            }

            Salesman salesman = new Salesman("Knut");
            for (int i = 0; i < 20; i++)
            {
                salesman.GetItems().Add(ItemFactory.GetRandomItem(salesman));
                salesman.SellItem();
            }
            Thread.Sleep(500);

            int uniqueCount = 0;
            ArrayList items = new ArrayList();
            foreach (Customer c in customers)
            {
                foreach (IItem item in c.GetItems())
                {
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                        uniqueCount++;
                    }
                }
            }
            Assert.That(uniqueCount, Is.EqualTo(20));
        }
    }
}