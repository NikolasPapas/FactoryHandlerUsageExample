using TestFactoryHandlerApplication.Common.BaseAImplementation;

namespace TestFactoryHandlerApplication.EmployerImplementation
{
    public class EmployerHandler : EmployerBaseHandler
    {
        public async override Task<object> GetData()
        {
            return new Employer()
            {
                FirstName = "FirstNameEmployer",
                LastName = "LastNameEmployer",
                Company = "TestCompany",
            };
        }
    }

    public class Employer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
    }
}