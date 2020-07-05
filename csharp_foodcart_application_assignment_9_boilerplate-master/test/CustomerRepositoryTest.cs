using FoodCart.Service.Models;
using FoodCart.Service.Repositories;
using NUnit.Framework;
using System.Collections.Generic;

namespace test
{
    [TestFixture]
    public class CustomerRepositoryTest
    {
        readonly CustomerRepository repository;

        public CustomerRepositoryTest()
        {
            repository = new CustomerRepository();
        }

        [Test, Order(1)]
        public void ShouldAddCustomer()
        {
            var customer = new Customer
            {
                CustomerName = "Tina"
            };
            var result = repository.AddCustomer(customer);

            Assert.That(result, Is.True);


        }
        [Test, Order(2)]
        public void ShouldGetCustomers()
        {
            var customers = repository.Get();

            Assert.That(customers, Is.TypeOf(typeof(List<Customer>)));

            Assert.That(customers.Count, Is.EqualTo(4));
        }

        [TestCase(2), Order(3)]
        public void ShouldGetCustomerByIdWithOrders(int customerId)
        {
            var customer = repository.Get(customerId);

            Assert.That(customer.FoodOrders, Is.Not.Null);

            Assert.That(customer.FoodOrders.Count, Is.EqualTo(3));
        }
    }
}