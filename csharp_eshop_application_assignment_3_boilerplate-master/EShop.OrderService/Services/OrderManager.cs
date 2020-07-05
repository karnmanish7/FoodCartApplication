using EShop.OrderService.Constants;
using EShop.OrderService.Models;
using System;

namespace EShop.OrderService.Services
{
    /*
     * This class manages orders and invoice generation
     * 
     * The class provides implementations of methods declared in both the interfaces : 
     *  - IOrderRepository (for Item add/retrieve operations)
     *  - IBillable (for invoice generation)
     * 
     */

    public class OrderManager : IBillable, IOrderRepository<Item>
    {
        

        
    }
}
