using TestFactoryHandlerApplication.Common.CustomerBaseImplementation;

namespace TestFactoryHandlerApplication.CustomerImplementation
{
    public class CustomerHandler : CustomerBaseHandler
    {
        public async override Task<object> GetData()
        {

            return new Customer()
            {
                FirstName = "FirstNameCustomer",
                LastName = "LastNameCustomer",
                Age = 99
            };
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}