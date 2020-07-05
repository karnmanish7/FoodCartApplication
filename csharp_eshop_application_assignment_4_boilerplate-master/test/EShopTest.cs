using EShop.OrderService.Models;
using EShop.OrderService.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    [TestFixture]
    public class EShopTest
    {
        readonly OrderRepository repository;

        public EShopTest()
        {
            repository = new OrderRepository();
        }

        [Test, Order(1)]
        public void ShouldRetrieveCompanyWiseMobileCatalog()
        {
            var keys = ProductCatalog.Catalog.Keys;

            Assert.That(keys.ElementAt(0), Is.EqualTo("Apple"));
            Assert.That(keys.ElementAt(3), Is.EqualTo("Samsung"));

            List<Product> valueList;
            var result = ProductCatalog.Catalog.TryGetValue("Apple", out valueList);
            Assert.True(result);

            Assert.That(valueList.Count, Is.EqualTo(3));
            Assert.That(valueList[0].ProductCode, Is.EqualTo("I001"));
        }

        [Test, Order(2)]
        public void ShouldPlaceOrderForProductInStock()
        {
            var order = new Order
            {
                ProductCode = "I001",
                CustomerName = "Vikram",
                Quantity = 2
            };

            var result = repository.PlaceOrder(order);
            Assert.That(result, Is.True);
        }

        [Test, Order(3)]
        public void ShouldPlaceOrderForProductNotInStock()
        {
            var order = new Order
            {
                ProductCode = "I002",
                CustomerName = "Vikram",
                Quantity = 1
            };

            var result = repository.PlaceOrder(order);
            Assert.That(result, Is.True);
        }

        [Test, Order(4)]
        public void ShouldGetOrders()
        {
            var orders = repository.GetOrders();
            Assert.That(orders.Count, Is.EqualTo(2));

            Assert.That(orders[0].ProductCode, Is.EqualTo("I001"));
            Assert.That(orders[0].Quantity, Is.EqualTo(2));
        }

        [Test, Order(5)]
        public void ShouldGetPendingOrders()
        {
            var dispatchList = repository.GetDispatchables();
            Assert.That(dispatchList.Count, Is.EqualTo(1));
            Assert.That(dispatchList[0].ProductCode, Is.EqualTo("I001"));
            Assert.That(dispatchList[0].Quantity, Is.EqualTo(2));
        }

        [Test, Order(6)]
        public void ShouldDispatchFirstOrderInQueue()
        {
            var dispatchedOrder = repository.DeliverOrder();
            Assert.That(dispatchedOrder.ProductCode, Is.EqualTo("I001"));
            Assert.That(dispatchedOrder.Quantity, Is.EqualTo(2));
        }

        [Test, Order(7)]
        public void ShouldDecrementDispatchableCountPostDispatch()
        {
            var dispatchList = repository.GetDispatchables();
            Assert.That(dispatchList.Count, Is.EqualTo(0));
        }

        [Test, Order(8)]
        public void ShouldRetrieveTransactionEventLog()
        {
            var eventLog = repository.GetEventLogs();
            Assert.That(eventLog.Count, Is.EqualTo(9));
            Assert.That(eventLog[0], Does.Contain("Fetching All Orders ready to be Delivered"));
            Assert.That(eventLog[8], Does.Contain("Order Processing Initiated"));

        }


    }
}
