using NUnit.Framework;
using System.Data.SqlClient;
using System.Linq;

namespace test
{
    public class CustomerRepositoryTest
    {
        readonly FoodContext context;
        CustomerRepository repository;
        public CustomerRepositoryTest()
        {
            context = new FoodContext();

        }
        [OneTimeSetUp]
        public void TestInit()
        {
            repository = new CustomerRepository(context);
        }
        [Test, Order(1)]
        public void ShouldReturnCustomerIdOnAddNewCustomer()
        {
            var customer = new OnlineCustomer
            {
                CustomerName = "VikramHH",
                Email = "vikram@gmail.com",
                PhoneNo = "9879879878",
                Category = "Standard",
                Address = "Bangaluru",
                Pincode = "570006"
            };
            var actualId = repository.Add(customer);
            var expectedId = 105;
            Assert.AreEqual(expectedId, actualId);
        }
        [Test, Order(2)]
        [TestCase(105, ExpectedResult = "VikramHH")]
        public string ShouldReturnCustomerById(int customerId)
        {
            var customer = repository.Get(customerId);
            return $"{customer.CustomerName}";
        }

        [Test, Order(3)]
        [TestCase(105, ExpectedResult = true)]
        public bool ShouldUpdateCustomer(int customerId)
        {
            var customer = new OnlineCustomer
            {
                CustomerName = "VikramH",
                Email = "vikramh@gmail.com",
                PhoneNo = "9879873333",
                Category = "Standard",
                Address = "Bangaluru",
                Pincode = "570004"
            };
            var res = repository.Update(customerId, customer);
            return res;
        }

        [TestCase(105), Order(4)]
        public void ShouldReturnCustomerByIdWithUpdatedDetails(int customerId)
        {
            var customer = repository.Get(customerId);
            Assert.That(customer.Email, Is.EqualTo("vikramh@gmail.com"));
            Assert.That(((OnlineCustomer)customer).Pincode, Is.EqualTo("570004"));
        }

        [Test, Order(6)]
        [TestCase(105, ExpectedResult = true)]
        public bool DeleteCustomerByIdServiceTest(int customerId)
        {
            var res = repository.Delete(customerId);
            return res;
        }

        [TestCase("Premium", ExpectedResult = 2), Order(7)]
        public int ShouldGetCustomersByCategory(string category)
        {
            var customers = repository.GetByCategory(category);
            var count = customers.Count();
            return count;
        }

        [TestCase("Premium", "570006", ExpectedResult = 1), Order(8)]
        public int ShouldGetCustomersByCategoryAndPincode(string category, string pincode)
        {

            var customers = repository.GetByCategoryAndPincode(category, pincode);
            var count = customers.Count();
            return count;
        }

        [TestCase(ExpectedResult = "Asha"), Order(9)]
        public string ShouldGetCustomersInAscendingOrder()
        {
            var customers = repository.GetCustomersOrderedByNameAsc();
            return customers[0].CustomerName;
        }


        [TestCase(ExpectedResult = "Usha"), Order(10)]
        public string ShouldGetCustomersInDescendingOrder()
        {
            var customers = repository.GetCustomersOrderedByNameDesc();
            return customers[0].CustomerName;
        }


        #region testing_sp

        //These two test cases shall fail for the first time, when stored procedures do not exist
        //Once database is created, stored procedures should be created and the below test cases should be executed

        [TestCase("Standard", ExpectedResult = 2), Order(7)]
        public int ShouldGetCustomersByCategoryUsingSp(string category)
        {
            var customers = context.Database.SqlQuery<OnlineCustomer>("GetOnlineCustomersByCategory @Category", new SqlParameter("@Category", category))
                .Cast<Customer>()
                .ToList();
            var count = customers.Count();
            return count;
        }

        [TestCase("Premium", "570007", ExpectedResult = 1), Order(8)]
        public int ShouldGetCustomersByCategoryAndPincodeUsingSp(string category, string pincode)
        {
            var customers = context.Database.SqlQuery<OnlineCustomer>("GetOnlineCustomersByCategoryAndPincode @Category, @Pincode", new SqlParameter("@Category", category), new SqlParameter("@Pincode", pincode))
                .Cast<Customer>()
                .ToList();
            var count = customers.Count();
            return count;
        }


        #endregion


    }
}
