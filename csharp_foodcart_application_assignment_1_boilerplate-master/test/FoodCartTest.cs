using FoodCart.Service.Models;
using FoodCart.Service.Service;
using NUnit.Framework;
using System;

namespace test
{
    public class FoodCartTest
    {
        FoodOrder foodOrder;
        OrderService orderService;

        [OneTimeSetUp]
        public void FoodCartTask1TestInit()
        {
            foodOrder = new FoodOrder();
            foodOrder.customerName = "VikramH";
            foodOrder.foodItem = "Veg Biriyani";
            foodOrder.orderDate = DateTime.Now;
            foodOrder.price = 150.00;
            foodOrder.quantity = 3;
            orderService = new OrderService();
        }

        [TestCase(50, ExpectedResult = 1), Order(1)]
        public int TestPlaceOrderWithCouponCode(int inputCouponCode)
        {
            foodOrder = new FoodOrder();
            foodOrder.customerName = "VikramH";
            foodOrder.foodItem = "Veg Biriyani";
            foodOrder.orderDate = DateTime.Now;
            foodOrder.price = 150.00;
            foodOrder.quantity = 3;
            foodOrder.couponCode = inputCouponCode;
            orderService.PlaceOrder(foodOrder);
            int actualOrderCount = orderService.GetOrderCount();
            return actualOrderCount;
        }

        [TestCase(ExpectedResult = 2), Order(2)]
        public int TestPlaceOrderWithoutCouponCode()
        {
            foodOrder = new FoodOrder();
            foodOrder.customerName = "VikramH";
            foodOrder.foodItem = "Veg Biriyani";
            foodOrder.orderDate = DateTime.Now;
            foodOrder.price = 150.00;
            foodOrder.quantity = 3;
            foodOrder.couponCode = null;
            orderService.PlaceOrder(foodOrder);
            int actualOrderCount = orderService.GetOrderCount();
            return actualOrderCount;
        }

        [Test, Order(3)]
        public void TestGetTotalItemsOrdered()
        {
            int actualTotalItemsOrdered = orderService.GetTotalItemsOrdered();
            int expectedTotalItemsOrdered = 6;
            Assert.AreEqual(expectedTotalItemsOrdered, actualTotalItemsOrdered);
        }

        [Test, Order(4)]
        public void TestGetAmount()
        {
            var actualValue = orderService.GetAmount();
            var expectedValue = 850;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase(ExpectedResult = "!!! Cannot Except Any Further Order !!!"), Order(5)]
        public string TestOrderOverflowException()
        {
            int count = 0;
            while (count++ <= 127)
                orderService.PlaceOrder(new FoodOrder());
            string result = orderService.PlaceOrder(new FoodOrder());
            return result;
        }

    }
}