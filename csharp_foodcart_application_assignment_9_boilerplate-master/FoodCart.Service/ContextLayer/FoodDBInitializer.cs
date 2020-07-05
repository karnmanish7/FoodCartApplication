namespace FoodCart.Service.ContextLayer
{
    /*
     * This class handles the responsibility of providing seed data for customers and food orders placed 
     * 
     */

    public class FoodDBInitializer
    {
        // create seed data as suggested in comments

        protected override void Seed(FoodContext context)
        {
            //add 3 customer records



            //add food order records with below break up:
            // 1st customer 2 orders
            // 2nd customer 3 orders
            // 3rd customer 1 order



            //add food order item records with below break up:
            // 1st order 1 items each of price Rs.50 and quantity 1
            // 2nd order 2 items each of price Rs.75 and quantity 2
            // 3rd order 1 item of Rs.220 and quantity 1
            // 4th order 1 item of Rs.120 and quantity 1
            // 5th order 1 item of Rs.320 and quantity 1
            // 6th order 1 item of Rs.160 and quantity 1


        }
    }
}