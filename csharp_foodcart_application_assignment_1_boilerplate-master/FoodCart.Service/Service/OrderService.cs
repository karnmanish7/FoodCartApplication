using FoodCart.Service.Models;

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

        public string PlaceOrder(FoodOrder order)
        {

        }

        public FoodOrder[] GetOrders()
        {

        }

        public string GetOrderDetails(FoodOrder order)
        {

        }

        private double CalculateBillAmount(FoodOrder order)
        {

        }

        public double GetAmount()
        {

        }

        public int GetTotalItemsOrdered()
        {

        }

        public int GetOrderCount()
        {

        }
    }
}
