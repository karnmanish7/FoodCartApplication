using FoodCart.Service.Models;

namespace FoodCart.Service.Service
{
    /*
     * 
     * This class extends the functionalities of FoodCart to fetch orders from cart and carry out aggregate operations on Cart Items that helps in :
     *      - getting total amount for items added to cart discounting the coupon amount (if any)
     *      - getting count of orders in cart
     *      - getting total of items ordered
     */

    public static class CartOperations
    {
        public static FoodOrder[] GetOrders(this FoodCart<FoodOrder> cart)
        {

        }

        public static double GetAmount(this FoodCart<FoodOrder> cart)
        {

        }

        private static double CalculateBillAmount(FoodOrder order)
        {

        }

        public static int GetTotalItemsOrdered(this FoodCart<FoodOrder> cart)
        {

        }

        public static int GetOrderCount(this FoodCart<FoodOrder> cart)
        {

        }
    }
}
