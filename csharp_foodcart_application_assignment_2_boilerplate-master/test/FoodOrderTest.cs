using FoodCart.Service.Models;
using FoodCart.Service.Service;
using NUnit.Framework;
using System;

namespace test
{
    public class FoodOrderTest
    {
        readonly CartService orderService = new CartService();

        [OneTimeSetUp]
        public void FoodCartTestInit()
        {

        }
        [TestCase(ExpectedResult = 1), Order(1)]
        public int TestOrderCountAfterPlacingOrder()
        {
            orderService.PlaceOrder(orderList[0]);
            int actualOrderCount = orderService.GetCart().GetOrderCount();
            return actualOrderCount;
        }

        [TestCase(ExpectedResult = true), Order(2)]
        public bool TestCheckCouponCodeTrue()
        {
            orderService.PlaceOrder(orderList[1]);
            var orders = orderService.GetCart().GetOrders();
            var actualCouponCodeStatus = ((OnlineOrder)orders[1]).couponCode.HasValue;
            return actualCouponCodeStatus;
        }

        [TestCase(ExpectedResult = false), Order(3)]
        public bool TestCheckCouponCodeFalse()
        {
            orderService.PlaceOrder(orderList[2]);
            var orders = orderService.GetCart().GetOrders();
            var actualCouponCodeStatus = ((OnlineOrder)orders[2]).couponCode.HasValue;
            return actualCouponCodeStatus;
        }

        [TestCase(ExpectedResult = 4), Order(4)]
        public int TestOrderCountAfterPlacingFourthOrder()
        {
            orderService.PlaceOrder(orderList[3]);
            int actualOrderCount = orderService.GetCart().GetOrderCount();
            return actualOrderCount;
        }

        [TestCase(ExpectedResult = 9), Order(5)]
        public int TestGetNumberOfItemsOrdered()
        {
            int actualNumberOfItemsOrdered = orderService.GetCart().GetTotalItemsOrdered();
            return actualNumberOfItemsOrdered;
        }

        [TestCase(ExpectedResult = 1050), Order(6)]
        public double TestGetAmount()
        {
            var actualAmount = orderService.GetCart().GetAmount();
            return actualAmount;
        }

        [TestCase(ExpectedResult = 5), Order(7)]
        public int TestOrderCount()
        {
            orderService.PlaceOrder(orderList[4]);
            int actualOrderCount = orderService.GetCart().GetOrderCount();
            return actualOrderCount;
        }
        [TestCase(ExpectedResult = 1450), Order(8)]
        public double TestGetAmountAfterOfflineOrder()
        {
            var actualAmount = orderService.GetCart().GetAmount();
            return actualAmount;
        }
        [TestCase(ExpectedResult = "Placed Order Successfullly!!"), Order(9)]
        [Repeat(122)]
        public string TestOrderTill126Times()
        {
            string orderResult = orderService.PlaceOrder(orderList[5]);
            return orderResult;
        }
        [TestCase(ExpectedResult = "You have exceeded the total no. of Orders that can be placed !!!"), Order(132)]
        public string TestPlaceOrderException()
        {
            string orderResult = orderService.PlaceOrder(orderList[5]);
            return orderResult;
        }

        #region SeedData

        readonly FoodOrder[] orderList = new FoodOrder[]
        {
            new OnlineOrder
            {
                customerName = "VikramH",
                address = "Bangaluru",
                mobileNo = "9876543210",
                foodItem = "Veg Biryani",
                orderDate = DateTime.Now,
                quantity = 2,
                price = 150,
                couponCode = 50
            },
            new OnlineOrder
            {
                customerName = "Bharathi",
                address = "Bangaluru",
                mobileNo = "9988776655",
                foodItem = "Veg Pulav",
                orderDate = DateTime.Now,
                quantity = 3,
                price = 100,
                couponCode = 50
            },
            new OnlineOrder
            {
                customerName = "Shiva",
                address = "Bangaluru",
                mobileNo = "9876556789",
                foodItem = "Hyderabadi Biryani",
                orderDate = DateTime.Now,
                quantity = 2,
                price = 150,
                couponCode=null
            },
            new OnlineOrder
            {
                customerName = "VikramH",
                address = "Bangaluru",
                mobileNo = "9876543210",
                foodItem = "Veg Biryani",
                orderDate = DateTime.Now,
                quantity = 2,
                price = 150,
                couponCode=50
            },
            new OfflineOrder
            {
                foodItem = "Pavbhaji",
                tableNumber = 10,
                orderDate = DateTime.Now,
                payMode = "Cash",
                price = 80,
                quantity = 5
            },
            new OfflineOrder
            {
                foodItem = "Sp. Pavbhaji",
                tableNumber = 5,
                orderDate = DateTime.Now,
                payMode = "Cash",
                price = 100,
                quantity = 4
            }
        };


        #endregion
    }
}
