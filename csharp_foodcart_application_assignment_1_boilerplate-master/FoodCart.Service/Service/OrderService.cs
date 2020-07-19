using FoodCart.Service.Models;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FoodCart.Service.Service
{
    /*
     * This class maintains collection of orders in the form of array
     * It also should maintain count to keep track on no. of orders placed (not to exceed 127)
     * 
     * The class provides functionalities to place order, get orders, order details and summarized order computations
     * The order details should also contain net bill amount calculated based on coupon amount deduction (if any)
     * 
     */

    public class OrderService
    {
        private List<FoodOrder> _order = new List<FoodOrder>();

        public string PlaceOrder(FoodOrder order)
        {
            if (this.GetOrderCount() > 127)
                return "!!! Cannot Except Any Further Order !!!";
            this._order.Add(order);
            return "";
        }

        public FoodOrder[] GetOrders()
        {
           return this._order.ToArray();
        }

        public string GetOrderDetails(FoodOrder order)
        {
            return "";
        }

        private double CalculateBillAmount(FoodOrder order)
        {
            return this.GetAmount();
        }

        public double GetAmount()
        {
            double totalAmount = 0;
            int discount = 0;
            foreach (var item in this._order)
            {
                totalAmount += item.price * item.quantity;
                if (item.couponCode != null)
                    discount += (int)item.couponCode;
            }
            return totalAmount - discount;

        }

        public int GetTotalItemsOrdered()
        {
            var totalItems = 0;
            foreach (var item in this._order)
            {
                totalItems += item.quantity;
            }
            return totalItems;
        }

        public int GetOrderCount()
        {
            return this._order.Count;
        }
    }
}
