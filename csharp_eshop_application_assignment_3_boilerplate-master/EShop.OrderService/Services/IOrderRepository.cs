namespace EShop.OrderService.Services
{
    /*
     * This generic interface contains method signatures for 
     * adding item,removing item, retrieving all/single item by itemname
     * 
     * Being generic, it should allow user to specify type on which operations can be performed in it's method signatures
     * 
     */

    public interface IOrderRepository<T> where T : class
    {
        
    }
}
