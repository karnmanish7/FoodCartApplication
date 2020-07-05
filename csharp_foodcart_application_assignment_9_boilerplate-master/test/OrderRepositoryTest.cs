using FoodCart.Service.Models;
using FoodCart.Service.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace test
{
    [TestFixture]
    public class OrderRepositoryTest
    {
        readonly OrderRepository repository;

        public OrderRepositoryTest()
        {
            repository = new OrderRepository();
        }

        [Test, Order(1)]
        public void ShouldAddOrder()
        {
            var order = new FoodOrder
            {
                ModeOfPayment = PaymentType.Wallet,
                CustomerId = 2,
                OrderDate = DateTime.Now
            };
            var orderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        ItemName = "Cheese Sandwich",
                        Quantity = 4,
                        Price = 75,
                        FoodOrder = order
                    },
                    new OrderItem
                    {
                        ItemName = "Veg Cheese Sandwich",
                        Quantity = 2,
                        Price = 95,
                        FoodOrder = order
                    }
                };

            var result = repository.AddOrder(orderItems);

            Assert.That(result, Is.True);


        }
        [TestCase(2), Order(2)]
        public void ShouldGetOrdersByCustomerIdWithFoodItemDetails(int customerId)
        {
            var orders = repository.Get(customerId);

            Assert.That(orders.Count, Is.EqualTo(4));

            Assert.That(orders[3].OrderItems.Count, Is.EqualTo(2));

            var amount = orders[3].OrderItems.Sum(i => i.Price * i.Quantity);

            Assert.That(amount, Is.EqualTo(490));
        }

        [Test, Order(3)]
        public void ShouldGetOrderWithFoodItemDetails()
        {
            var orders = repository.Get();

            Assert.That(orders[1].OrderItems.Count, Is.EqualTo(2));

            var amount = orders[1].OrderItems.Sum(i => i.Price * i.Quantity);

            Assert.That(amount, Is.EqualTo(300));
        }

        [Test, Order(4)]
        public void ShouldFailToAddOrderWithSameOrderIdAndItemName()
        {
            var order = new FoodOrder
            {
                ModeOfPayment = PaymentType.Wallet,
                CustomerId = 2,
                OrderDate = DateTime.Now
            };
            var orderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        ItemName = "Cheese Sandwich",
                        Quantity = 4,
                        Price = 75,
                        FoodOrder = order
                    },
                    new OrderItem
                    {
                        ItemName = "Cheese Sandwich",
                        Quantity = 2,
                        Price = 95,
                        FoodOrder = order
                    }
                };

            //repository.AddOrder(orderItems);

            Assert.That(() => repository.AddOrder(orderItems),
                Throws.TypeOf<DbUpdateException>()
                .And
                .InnerException.TypeOf<UpdateException>()
                .Or
                .InnerException.TypeOf<SqlException>()
                );
        }
    }
}
