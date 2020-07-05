using System.ComponentModel.DataAnnotations;

namespace FoodCart.Service.Models
{
    /*
     * This class models Customer data with attributes for customer id, name, email and phoneno
     * It should also contain attribute for maintain row version
     */

    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
