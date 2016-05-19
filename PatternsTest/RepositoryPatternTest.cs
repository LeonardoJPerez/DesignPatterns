using NUnit.Framework;
using RepositoryPattern;
using RepositoryPattern.Model;
using RepositoryPattern.Repositories;
using System;
using System.Linq;

namespace PatternsTest
{
    [TestFixture]
    public class RepositoryPatternTest
    {
        private static IRepository<Customer> repository;

        [SetUp]
        public void Init()
        {
            repository = new CustomerRepository();
        }

        [Test]
        public void GetCustomersTest()
        {
            var customers = repository.Get(x => true);

            Console.WriteLine($"Customer count: {customers.Count()}");
            Assert.Greater(customers.Count(), 0);
        }

        [Test]
        public void GetCustomerTest()
        {
            var customer = repository.Get("id");

            Console.WriteLine($"Customer ID: {customer.Id}");
            Assert.IsNotNull(customer);
            Assert.IsNotEmpty(customer.Id);
        }

        [Test]
        public void DeleteCustomerTest()
        {
            var success = repository.Delete("id");
            Assert.IsTrue(success);
        }

        [Test]
        public void SaveCustomerTest()
        {
            var customer = new Customer();
            repository.Save(customer);

            Assert.IsNotEmpty(customer.Id);
        }
    }
}