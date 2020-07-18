using System;

namespace FoodCart.Service.Models
{
    //Identify the attributes for FoodOrder based on requirement and define the FoodOrder class fields

    public class FoodOrder
    {
        public int quantity { get; set; }
        public string customerName { get; set; }
        public string foodItem { get; set; }
        public DateTime orderDate { get; set; }
        public double price { get; set; }
        public int? couponCode { get; set; }
    }
}
