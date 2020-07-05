using EShop.OrderService.Constants;
using EShop.OrderService.Models;
using EShop.OrderService.Services;
using NUnit.Framework;
using System;

namespace test
{
    public class EShopOrderTest
    {
        OrderManager orderManager;
        Item item;

        [OneTimeSetUp]
        public void TestInit()
        {
            orderManager = new OrderManager();
            item = new Item
            {
                itemName = "Veg Biriyani",
                price = 150,
                quantity = 1
            };
            orderManager.Add(item);
        }

        [TestCase(ExpectedResult = 2), Order(1)]
        public int ShouldUpdateItemCountOnAdd()
        {
            item = new Item
            {
                itemName = "Chicken Biriyani",
                price = 200,
                quantity = 1
            };
            orderManager.Add(item);
            return orderManager.GetCount();
        }

        [TestCase("Veg Biriyani", ExpectedResult = 150), Order(2)]
        [TestCase("Chicken Biriyani", ExpectedResult = 200)]
        public int ShouldGetItemDetailsByName(string itemname)
        {
            var itemDetails = orderManager.Get(itemname);
            var actualValue = itemDetails.price;

            Assert.That(itemDetails, Is.TypeOf<Item>());

            return actualValue;
        }

        [Test, Order(4)]
        public void ShouldGenerateInvoiceAsDisplayableOnScreen()
        {
            Customer customer = new Customer
            {
                firstName = "Vikram",
                lastName = "H"
            };
            string actualInvoice = orderManager.GenerateInvoice(customer, InvoiceOptions.SCREEN);
            string expectedInvoice =
            $"Customer Name : Vikram. H\n" +
            $"Invoice Date : {DateTime.Now.ToShortDateString()} \n" +
            $"Item Name : Veg Biriyani Price Rs. : 150 Quanity : 1 Amount Rs. : 150\n" +
            $"Item Name : Chicken Biriyani Price Rs. : 200 Quanity : 1 Amount Rs. : 200\n\n" +
            $"Total Amount Rs. : 350";
            StringAssert.Contains(expectedInvoice, actualInvoice);
        }


        [Test, Order(5)]
        public void ShouldGenerateInvoiceAsPrintable()
        {
            Customer customer = new Customer
            {
                firstName = "Vikram",
                lastName = "H"
            };
            string actualInvoice = orderManager.GenerateInvoice(customer, InvoiceOptions.PRINTER);
            string expectedInvoice = "Printing Invoice....";
            StringAssert.Contains(expectedInvoice, actualInvoice);
        }


        [Test, Order(6)]
        public void ShouldGenerateInvoiceAsMailable()
        {
            Customer customer = new Customer
            {
                firstName = "Vikram",
                lastName = "H"
            };
            string actualInvoice = orderManager.GenerateInvoice(customer, InvoiceOptions.EMAIL);
            string expectedInvoice = "Invoice Mailed";

            StringAssert.Contains(expectedInvoice, actualInvoice);
        }


        [Test, Order(7)]
        public void ShouldGenerateInvoiceAsDownloadable()
        {
            Customer customer = new Customer
            {
                firstName = "Vikram",
                lastName = "H"
            };
            string actualInvoice = orderManager.GenerateInvoice(customer, InvoiceOptions.PDF);
            string expectedInvoice = "invoice.pdf is generated and downloaded";
            StringAssert.Contains(expectedInvoice, actualInvoice);
        }


        [Test, Order(5)]
        public void ShouldImplementMultipleInterfaces()
        {
            Assert.That(orderManager, Is.AssignableTo<IBillable>());
            Assert.That(orderManager, Is.AssignableTo<IOrderRepository<Item>>());
        }

    }
}